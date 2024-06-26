using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1.DataAccess;
using ConsoleApp1.Models;
using ConsoleApp1.JsonProperties;
using ConsoleApp1.YOLO;

namespace ConsoleApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PracContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PAD2RB4\\SQLEXPRESS;Initial Catalog=Prac;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            using var context = new PracContext(optionsBuilder.Options);

            string filePath = "C:\\Users\\shesh\\source\\repos\\ConsoleApp1\\ConsoleApp1\\res.json";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return;
            }

            string jsonResponse;
            try
            {
                jsonResponse = await File.ReadAllTextAsync(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
                return;
            }

            List<PracJson> pracJsonList;
            try
            {
                pracJsonList = JsonSerializer.Deserialize<List<PracJson>>(jsonResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                return;
            }

            var specificEmail = "231367@astanait.edu.kz"; 

            foreach (var pracJson in pracJsonList)
            {
                var relevantAnnotations = pracJson.Annotations
                    .Where(annotation => annotation.CompletedBy.Email == specificEmail)
                    .ToList();

                foreach (var annotation in relevantAnnotations)
                {
                    var poleResults = annotation.Result
                        .ToList();

                    foreach (var result in poleResults)
                    {
                        int imageWidth = result.OriginalWidth ?? 1280; 
                        int imageHeight = result.OriginalHeight ?? 720;
                        var (centerX, centerY, normWidth, normHeight) = YoloConverter.ConvertToYoloFormat(
                            (float)result.Value.X,
                            (float)result.Value.Y,
                            (float)result.Value.Width,
                            (float)result.Value.Height,
                            imageWidth,
                            imageHeight);
                        var newPrac = new Prac
                            {
                                Id = result.Id,
                                X = centerX,//(float?)result.Value.X,
                                Y = centerY, //(float?)result.Value.Y,
                                Height = normHeight, //(float?)result.Value.Height,
                                Width = normWidth, //(float?)result.Value.Width,
                                RectangleLabels = string.Join(", ", result.Value.RectangleLabels),
                                Image = pracJson.Data.Image,
                                CreatedAt = annotation.CreatedAt
                            };

                            context.Pracs.Add(newPrac);
                    }
                }
            }

            await context.SaveChangesAsync();
        }
    }
}

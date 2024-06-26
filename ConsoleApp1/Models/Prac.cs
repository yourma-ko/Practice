using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Prac
    {
        public string Id { get; set; }
        public float? X { get; set; }
        public float? Y { get; set; }
        public float? Height { get; set; }
        public float? Width { get; set; }
        public string? RectangleLabels { get; set; }
        public string? Image { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}

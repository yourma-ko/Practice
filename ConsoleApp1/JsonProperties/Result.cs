using ConsoleApp1.JsonProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Result
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public Value? Value { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    [JsonPropertyName("to_name")]
    public string? ToName { get; set; }

    [JsonPropertyName("from_name")]
    public string? FromName { get; set; }

    [JsonPropertyName("image_rotation")]
    public int? ImageRotation { get; set; }

    [JsonPropertyName("original_width")]
    public int? OriginalWidth { get; set; }

    [JsonPropertyName("original_height")]
    public int? OriginalHeight { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class CompletedBy
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }
}
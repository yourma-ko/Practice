using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1.JsonProperties
{
    public class PracJson
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("annotations")]
        public List<Annotation>? Annotations { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}

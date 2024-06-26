using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsoleApp1.JsonProperties
{

    public class Annotation
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("completed_by")]
        public CompletedBy CompletedBy { get; set; }

        [JsonPropertyName("result")]
        public List<Result> Result { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("lead_time")]
        public double LeadTime { get; set; }

        [JsonPropertyName("task")]
        public int Task { get; set; }

        [JsonPropertyName("project")]
        public int Project { get; set; }

        [JsonPropertyName("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        [JsonPropertyName("was_cancelled")]
        public bool WasCancelled { get; set; }

        [JsonPropertyName("ground_truth")]
        public bool GroundTruth { get; set; }
    }
}
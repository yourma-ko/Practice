using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1.JsonProperties
{
    public class Data
    {
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiAIMaker.Models
{
    public class ApiModels
    {
        public class GeminiRequest
        {
            [JsonPropertyName("contents")]
            public List<GeminiContent> Contents { get; set; } = new();
        }

        public class GeminiContent
        {
            [JsonPropertyName("parts")]
            public List<GeminiPart> Parts { get; set; } = new();
        }

        public class GeminiPart
        {
            [JsonPropertyName("text")]
            public string Text { get; set; } = string.Empty;
        }
    }
}

using ApiAIMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static ApiAIMaker.Models.ApiModels;


namespace ApiAIMaker.Services
{
    public class AiService
    {
        private const string Api_url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent";
        private const string Api_key = "AIzaSyDt12sqWt5U5Vpo4TSCoVBI5u03K_HjpjA";
        private const string Api_header = "x-goog-api-key";
        private readonly HttpClient _client = new();

        public AiService()
        {
            _client.BaseAddress = new Uri(Api_url);
            _client.DefaultRequestHeaders.Add(Api_header, Api_key);
        }

        private async Task<GeminiResponse>? GetAiResponse(RequestModel request)
        {
            var prompt = $"Use EXCLUSIVELY the documentation {request.WebsiteUrl} and the description {request.Description} to generate fully functional, secure, " +
                $"idiomatic code in plain {request.Language} with no frameworks or external libraries (standard library only); the output must be CODE ONLY (no accompanying text), " +
                $"with at most brief in-code comments; include all imports, handle errors (retry/backoff, timeouts, input validation), " +
                $"add simple logging and configuration via environment variables; optionally include tests using only the standard library (e.g., unittest); " +
                $"state any assumptions only as comments and choose the simplest solution.";

            var response = await _client.PostAsJsonAsync("", new GeminiRequest()
            {
                Contents = new List<GeminiContent>()
                {
                    new GeminiContent() {
                    Parts = new List<GeminiPart>()
                    {
                         new GeminiPart() { Text = prompt }
                    }}
                }
            });

            var jsonResponse = await response.Content.ReadAsStringAsync();

            var geminiResponse = JsonSerializer.Deserialize<GeminiResponse>(jsonResponse);
            if (geminiResponse == null)
            {
                throw new InvalidOperationException("Failed to deserialize GeminiResponse from API response.");
            }
            return geminiResponse;
        }

        public string AiResponse(RequestModel request)
        {
            var aiResponse = GetAiResponse(request).Result;
            if(aiResponse.Candidates.Count > 0)
            {
                var sb = new StringBuilder();
                foreach (var part in aiResponse.Candidates[0].Content.Parts)
                {
                    sb.Append(part.Text);
                }
                return sb.ToString();
            }
            return string.Empty;
        }

    }
}

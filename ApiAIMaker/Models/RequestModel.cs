using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAIMaker.Models
{
    public class RequestModel
    {
        public RequestModel(string description, string websiteUrl, string language)
        {
            Description = description;
            WebsiteUrl = websiteUrl;
            Language = language;
        }

        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string Language{ get; set;}
    }
}

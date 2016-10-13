using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum.WebApi.Models
{
    public class Feedback
    {
        public Feedback(string retrospectiveName, string personName, string body, string type)
        {
            RetrospectiveName = retrospectiveName;
            PersonName = personName;
            Body = body;
            Type = type;
        }

        public string RetrospectiveName { get; private set; }

        public string PersonName { get; private set; }

        public string Body { get; private set; }

        public string Type { get; private set; }
    }
}
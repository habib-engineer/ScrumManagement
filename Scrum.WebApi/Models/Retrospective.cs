using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum.WebApi.Models
{
    public class Retrospective
    {
        private readonly IList<string> _participants;

        public Retrospective(string name, string summary, DateTime date)
        {
            Name = name;
            Summary = summary;
            Date = date;
            _participants = new List<string>() { "Part 1", "Part 2", "Part 3"};
        }
        public string Name { get; private set; }
        
        public string Summary { get; private set; }
        
        public DateTime Date { get; private set; }

        public IEnumerable<string> Participants 
        {
            get { return _participants; } 
        }

        public void AddParticipant(string participant)
        {
            _participants.Add(participant);
        }
    }
}
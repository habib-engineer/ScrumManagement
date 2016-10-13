using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum.WebApi.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly IList<Feedback> _feedbackItems;

        public FeedbackRepository()
        {
            _feedbackItems = new List<Feedback>() { 
                new Feedback ("Retrospective1", "Feed back1", "dfdfd df", "Positive")
                , new Feedback ("Retrospective1", "Feed back2", "lasdfdasf adsf ", "Idea")
                , new Feedback ("Retrospective1", "Feed back3", "asdfasf adfsasf", "Negative")
                , new Feedback ("Retrospective1", "Feed back4", "asdfasdf adsfas", "Praise")
                ,new Feedback ("Retrospective2", "Feed back1", "dfdfd df", "Positive")
                , new Feedback ("Retrospective2", "Feed back2", "lasdfdasf adsf ", "Idea")
                , new Feedback ("Retrospective2", "Feed back3", "asdfasf adfsasf", "Negative")
                , new Feedback ("Retrospective2", "Feed back4", "asdfasdf adsfas", "Praise")
                ,new Feedback ("Retrospective3", "Feed back1", "dfdfd df", "Positive")
                , new Feedback ("Retrospective3", "Feed back2", "lasdfdasf adsf ", "Idea")
                , new Feedback ("Retrospective3", "Feed back3", "asdfasf adfsasf", "Negative")
                , new Feedback ("Retrospective3", "Feed back4", "asdfasdf adsfas", "Praise")
            
            };
        }


        IEnumerable<Feedback> IFeedbackRepository.GetFeedbacksByRetrospective(string retrospectiveName)
        {
            var feedbacks = _feedbackItems.Where(f => f.RetrospectiveName == retrospectiveName).ToList();
            return feedbacks;
        }

        void IFeedbackRepository.Add(Feedback feedback)
        {
            _feedbackItems.Add(feedback);
        }

        Feedback IFeedbackRepository.Create(string retrospectiveName)
        {
            return new Feedback(retrospectiveName, null, null, null);
        }
    }
}
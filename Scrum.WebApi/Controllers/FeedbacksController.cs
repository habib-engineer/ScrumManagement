using Scrum.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Scrum.WebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:13778", "*", "*")]
    public class FeedbacksController : ApiController
    {
        private IFeedbackRepository _feedbackRepository;
        public FeedbacksController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        // GET: api/Feedbacks
        public IEnumerable<Feedback> Get(string retrospective)
        {
            return _feedbackRepository.GetFeedbacksByRetrospective(retrospective);
        }

        // GET: api/Feedbacks/5
       [HttpGet]
        public Feedback Create(string retrospectiveName)
        {
            return _feedbackRepository.Create(retrospectiveName);
        }

        // POST: api/Feedbacks
        public void Post([FromBody]Feedback feedback)
        {
            _feedbackRepository.Add(feedback);
        }

        // PUT: api/Feedbacks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Feedbacks/5
        public void Delete(int id)
        {
        }
    }
}

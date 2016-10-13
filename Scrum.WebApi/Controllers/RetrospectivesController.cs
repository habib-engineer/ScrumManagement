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
    public class RetrospectivesController : ApiController
    {
        private IRetrospectiveRepository _retrospectiveRepository;
        public RetrospectivesController(IRetrospectiveRepository retrospectiveRepository)
        {
            _retrospectiveRepository = retrospectiveRepository;
        }

        // GET: api/Retrospectives
        public IEnumerable<Retrospective> Get()
        {
            return _retrospectiveRepository.GetAll();
        }

        // GET: api/Retrospectives/name
        public Retrospective Get(string name)
        {
            if (name == "0")
                return _retrospectiveRepository.Create();
            else
                return _retrospectiveRepository.GetByName(name);
        }

        // GET: api/Retrospectives/5
        public IEnumerable<Retrospective> Get(DateTime searchdate)
        {
            return _retrospectiveRepository.GetByDate(searchdate);
        }

        // POST: api/Retrospectives
        public void Post([FromBody]Retrospective retrospective)
        {
            _retrospectiveRepository.Add(retrospective);
        }

        // PUT: api/Retrospective/5
        public void Put(string name, [FromBody]Retrospective value)
        {

        }

        // DELETE: api/Retrospective/5
        public void Delete(int id)
        {
        }
    }
}

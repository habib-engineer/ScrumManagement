using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrum.WebApi.Models
{
    public class RetrospectiveRepository : IRetrospectiveRepository
    {
        private readonly IList<Retrospective> _retrospectives;

        public RetrospectiveRepository()
        {
            _retrospectives = new List<Retrospective>() 
            {
                new Retrospective("Retrospective1", "Retrospective 1 Summary", DateTime.Now.AddDays(1))
                , new Retrospective("Retrospective2", "Retrospective 2 Summary", DateTime.Now.AddDays(1))
                , new Retrospective("Retrospective3", "Retrospective 3 Summary", DateTime.Now.AddDays(1))
                , new Retrospective("Retrospective4", "Retrospective 4 Summary", DateTime.Now)
                , new Retrospective("Retrospective5", "Retrospective 5 Summary", DateTime.Now)
                , new Retrospective("Retrospective6", "Retrospective 6 Summary", DateTime.Now)
            };
        }

        IEnumerable<Retrospective> IRetrospectiveRepository.GetAll()
        {
            return _retrospectives;
        }

        Retrospective IRetrospectiveRepository.GetByName(string name)
        {
            var retrospective = _retrospectives.FirstOrDefault(r => r.Name == name);
            return retrospective;
        }
        IEnumerable<Retrospective> IRetrospectiveRepository.GetByDate(DateTime date)
        {
            var retrospectives = _retrospectives.Where(r => r.Date.Date == date.Date);
            return retrospectives;
        }

        void IRetrospectiveRepository.Add(Retrospective retrospective)
        {
            _retrospectives.Add(retrospective);
        }

        Retrospective IRetrospectiveRepository.Create()
        {
            return new Retrospective(null, null, DateTime.Now);
        }
    }
}
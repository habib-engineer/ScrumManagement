using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.WebApi.Models
{
    public interface IRetrospectiveRepository
    {
        IEnumerable<Retrospective> GetAll();

        IEnumerable<Retrospective> GetByDate(DateTime date);

        Retrospective GetByName(string name);

        void Add(Retrospective retrospective);

        Retrospective Create();
    }
}

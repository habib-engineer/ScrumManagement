using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.WebApi.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetFeedbacksByRetrospective(string retrospectiveName);

        void Add(Feedback feedback);

        Feedback Create(string retrospectiveName);
    }
}

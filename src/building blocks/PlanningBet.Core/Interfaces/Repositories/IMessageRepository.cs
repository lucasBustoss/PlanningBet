using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningBet.Core.Interfaces.Repositories
{
    public interface IMessageRepository<T>
    {
        IEnumerable<T> FindAll();
        Task<bool> CreateOrUpdate(T model);
    }
}

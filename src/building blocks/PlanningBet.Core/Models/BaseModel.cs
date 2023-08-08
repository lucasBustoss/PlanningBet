using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningBet.Core.Models
{
    public abstract class BaseModel
    {
        public virtual Guid Id { get; set; }
    }
}

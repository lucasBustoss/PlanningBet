using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningBet.Core.Models.Requests
{
    public abstract class BaseModelRequest
    {
        public abstract List<string> Errors { get; protected set; }
        public abstract bool IsValid();
        public abstract void Validate();
    }
}

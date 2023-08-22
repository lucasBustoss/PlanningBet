using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlanningBet.Core.Models;

public abstract class BaseModel
{
    public virtual Guid Id { get; set; }
}

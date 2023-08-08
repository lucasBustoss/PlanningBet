using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningBet.Core.Interfaces.Controllers
{
    public interface ICrudController<T>
    {
        ActionResult GetAll();
        ActionResult GetById();
        ActionResult Create(T modelRequest);
        ActionResult Update(T modelRequest);
        ActionResult Delete();
    }
}

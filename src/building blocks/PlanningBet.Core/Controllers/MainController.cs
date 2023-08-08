﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PlanningBet.Core.Controllers;

[ApiController]
[Authorize]
public abstract class MainController : ControllerBase
{
    protected ActionResult OkResponse(object data)
    {
        return Ok(new
        {
            StatusCode = HttpStatusCode.OK,
            Data = data
        });
    }

    protected ActionResult CreatedResponse(string uri, object data)
    {
        return Created(uri, new
        {
            StatusCode = HttpStatusCode.Created,
            Data = data
        });
    }

    protected ActionResult BadRequestResponse(string message)
    {
        return BadRequest(new
        {
            StatusCode = HttpStatusCode.BadRequest,
            Error = message
        });
    }

    protected ActionResult NotFoundResponse()
    {
        return NotFound(new
        {
            StatusCode = HttpStatusCode.NotFound,
            Error = "Recurso não encontrado."
        });
    }
}

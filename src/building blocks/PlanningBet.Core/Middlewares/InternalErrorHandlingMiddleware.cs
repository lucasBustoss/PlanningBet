using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using System.Web.Http;

namespace PlanningBet.Core.Middlewares;

public class InternalErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public InternalErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);

            var a = context.Response.HttpContext.Request;

            if (context.Response.StatusCode == 401)
                throw new HttpResponseException(HttpStatusCode.Unauthorized);

            if (context.Response.StatusCode == 403)
                throw new HttpResponseException(HttpStatusCode.Forbidden);

            if (context.Response.StatusCode == 404 || context.Response.StatusCode == 405)
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var statusCode = HttpStatusCode.InternalServerError;
        var error = "Internal Server Error";

        // Customize the response message for specific exceptions if needed.
        if (exception is InvalidOperationException)
        {
            statusCode = HttpStatusCode.InternalServerError;
            error = "Dependency Injection Error";
        }
        else if (exception is HttpResponseException)
        {
            var httpException = exception as HttpResponseException;

            if (httpException != null)
            {
                statusCode = httpException.Response.StatusCode;
                error = GetErrorMessage((int)statusCode);
            }
        }
        else
        {
            statusCode = HttpStatusCode.BadRequest;
            error = exception.Message;
        }

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        var response = new
        {
            StatusCode = (int)statusCode,
            Error = error
        };

        return JsonSerializer.SerializeAsync(context.Response.Body, response);
    }

    private static string GetErrorMessage(int statusCode)
    {
        switch (statusCode)
        {
            case 401:
                return "Not authorized.";

            case 403:
                return "Access denied.";

            case 404:
                return "Resource not found.";

            default:
                return "Internal server error.";
        }
    }
}
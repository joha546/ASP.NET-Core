using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware
{
    public class ShortCircuitingMiddleware
    {
        private readonly RequestDelegate _next;

        public ShortCircuitingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Short-circuit the request pipeline for a specific condition
            if (context.Request.Path.StartsWithSegments("/shortcircuit"))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Request short-circuited by middleware.");
                return;
            }

            // Call the next middleware in the pipeline
            await _next(context);
        }
    }
}

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
public class MyMiddleware
{
    private readonly RequestDelegate _next;
    public MyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpCOntext)
    {
        await httpCOntext.Response.WriteAsync("<div>Hai Athulya </div>");
        await _next(httpCOntext);
        await httpCOntext.Response.WriteAsync("<div>All the Best! </div>");
    }
}
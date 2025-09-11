using Services;
using DTOs;

namespace WebAPI
{
    public static class UserEndpoints
    {
        // Just so make it clear: the 'this' keyword in the parameter defines an extension method for WebApplication.
        // This way you can call any method from MapUserEndpoints from any instance of the WebApplication class.
        public static void MapUserEndpoints(this WebApplication app) { 

            app.MapPost(){}
        }
    }
}

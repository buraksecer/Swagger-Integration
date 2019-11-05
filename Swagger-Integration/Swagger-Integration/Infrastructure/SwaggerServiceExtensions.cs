using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Swagger_Integration.Infrastructure
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new Info
                {
                    Title = "Swagger API v1.0",
                    Version = "v1.0",
                    Contact = new Contact()
                    {
                        Name = "Burak SEÇER",
                        Url = "http://buraksecer.com",
                        Email = "burakscr@gmail.com"
                    }
                });
            });
            return services;
        }
    }
}

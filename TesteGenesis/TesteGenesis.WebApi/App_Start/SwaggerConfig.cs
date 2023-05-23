using System.Web.Http;
using WebActivatorEx;
using TesteGenesis.WebApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace TesteGenesis.WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c => { c.SingleApiVersion("v1", "TesteGenesis.WebApi"); })
                .EnableSwaggerUi(c => {});
        }
    }
}

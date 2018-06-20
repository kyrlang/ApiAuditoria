using System.Web.Http;
using WebActivatorEx;
using ApiAuditoria;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ApiAuditoria
{
    //Passo a passo swagger
    //https://www.c-sharpcorner.com/article/implement-swagger-ui-with-web-api/

    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
                            .EnableSwagger(c => c.SingleApiVersion("v1", "ApiAuditoria"))
                            .EnableSwaggerUi();

        }
    }
}

using System.Web.Http;
using WebActivatorEx;
using AlmacenEbenEzer;
using Swashbuckle.Application;
using System.IO;
using System;
using System.Reflection;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace AlmacenEbenEzer
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        var baseDirectory = AppDomain.CurrentDomain.BaseDirectory + @"\bin\";
                        var commentsFileName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
                        var commentsFile = Path.Combine(baseDirectory, commentsFileName);

                        c.SingleApiVersion("v1", "Almacen Eben Ezer")
                        .Description("API del sistema de inventario del Almacen Eben Ezer")
                        .TermsOfService("© ALMACEN EBEN EZER")
                        .License(lc => lc
                            .Name("Repositorio GitHub")
                            .Url("https://github.com/josue0ghost/ProyectoED2"));

                        c.IncludeXmlComments(commentsFile);
                    })
                .EnableSwaggerUi();
        }
    }
}

using System;
using System.Web.Http;
using ChinookRESTier.API.Controllers;
using ChinookRESTier.API.Models;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Restier.EntityFramework;

namespace ChinookRESTier.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

#if !PROD
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
#endif

            config.Filter().Expand().Select().OrderBy().MaxTop(100).Count().SetTimeZoneInfo(TimeZoneInfo.Utc);

            config.UseRestier<ChinookApi>((services) =>
            {
                // This delegate is executed after OData is added to the container.
                // Add you replacement services here.
                services.AddEF6ProviderServices<ChinookModel>();

                services.AddSingleton(new ODataValidationSettings
                {
                    MaxTop = 5,
                    MaxAnyAllExpressionDepth = 3,
                    MaxExpansionDepth = 3, 

                });
            });

            config.MapHttpAttributeRoutes();

            config.MapRestier<ChinookApi>("api", "");
        }
    }
}
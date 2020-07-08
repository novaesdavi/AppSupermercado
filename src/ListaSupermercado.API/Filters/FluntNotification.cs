using ListaSupermercado.API.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSupermercado.Application.Filters
{
    public static class FluntNotificationContext
    {
        public static void AddFluntNotificationContext(this IServiceCollection services)
        {
            services.AddScoped<INotificationContext, NotificationContext>();
        }
    }
}

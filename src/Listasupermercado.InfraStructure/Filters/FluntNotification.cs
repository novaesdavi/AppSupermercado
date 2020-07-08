using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSupermercado.Infrastructure.Filters
{
    public static class FluntNotificationContext
    {
        public static void AddFluntNotificationContext(this IServiceCollection services)
        {
            services.AddScoped<INotificationContext, NotificationContext>();
        }
    }
}

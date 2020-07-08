using ListaSupermercado.Application.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaSupermercado.API.Filters
{
    public class NotificationFilter : IAsyncResultFilter
    {

        INotificationContext _fluntcontext;
        public NotificationFilter(INotificationContext fluntcontext)
        {
            _fluntcontext = fluntcontext;
        }

        public Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}

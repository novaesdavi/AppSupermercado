using ListaSupermercado.Application.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaSupermercado.API.Filters
{
    public class NotificationFilter : IActionFilter
    {

        INotificationContext _fluntcontext;
        public NotificationFilter(INotificationContext fluntcontext)
        {
            _fluntcontext = fluntcontext;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_fluntcontext.Invalid)
            {
                context.Result = new ObjectResult(_fluntcontext.Notifications)
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) { }


    }

}

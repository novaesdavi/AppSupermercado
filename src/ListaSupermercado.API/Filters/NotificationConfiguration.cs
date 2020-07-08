using System;
using ListaSupermercado.Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ListaSupermercado.API.Filters
{
    public class NotificationConfiguration : IActionFilter
    {
        //INotificationContext _fluntcontext;
        //public NotificationConfiguration(INotificationContext fluntcontext)
        //{
        //    _fluntcontext = fluntcontext;
        //}

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var teste = _fluntcontext;
            if (!filterContext.ModelState.IsValid)
            {
                filterContext.Result = new BadRequestObjectResult(filterContext.ModelState);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var teste = _fluntcontext;
            //filterContext.HttpContext.(_fluntcontext, out var teste01);
            if (!filterContext.ModelState.IsValid)
            {
                filterContext.Result = new BadRequestObjectResult(filterContext.ModelState);
            }
        }
    }
}

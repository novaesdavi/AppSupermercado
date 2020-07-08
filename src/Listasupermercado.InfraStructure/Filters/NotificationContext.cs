using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Notifications;
using ListaSupermercado.Infrastructure.Filters;

namespace ListaSupermercado.Infrastructure.Filters
{
    public class NotificationContext : Notifiable, INotificationContext
    {
        public NotificationContext() : base() { }
    }
}

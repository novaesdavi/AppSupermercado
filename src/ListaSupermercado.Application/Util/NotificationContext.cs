using Flunt.Notifications;
using ListaSupermercado.Application.Filters;


namespace ListaSupermercado.API.Filters
{
    public class NotificationContext : Notifiable, INotificationContext
    {
        public NotificationContext() : base() { }
    }
}

using System.Collections.Generic;
using Flunt.Notifications;

namespace ListaSupermercado.Application.Filters
{
    public interface INotificationContext
    {
        public IReadOnlyCollection<Notification> Notifications { get; }
        public bool Invalid { get; }
        public bool Valid { get; }
        void AddNotification(Notification notification);
    }
}

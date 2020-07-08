using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Notifications;

namespace ListaSupermercado.Infrastructure.Filters
{
   public interface INotificationContext
    {
        public IReadOnlyCollection<Notification> Notifications { get; }
        public bool Invalid { get; }
        public bool Valid { get; }
        void AddNotification(Notification notification);
    }
}

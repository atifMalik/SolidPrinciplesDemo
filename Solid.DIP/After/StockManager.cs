using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.After
{
    public class StockManager
    {
        private MessageFactoryBase _messageFactory;
        private INotification _notificationMethod;

        public StockManager(MessageFactoryBase messageFactory, INotification notificationMethod)
        {
            _messageFactory = messageFactory;
            _notificationMethod = notificationMethod;
        }

        public void NotifyCustomer()
        {
            string message = _messageFactory.GetMessageForUser();
            _notificationMethod.SendNotification(message);
        }
    }
}

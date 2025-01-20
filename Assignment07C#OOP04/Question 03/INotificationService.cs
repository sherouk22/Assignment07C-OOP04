using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04.Question_03
{
    public interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    }
}

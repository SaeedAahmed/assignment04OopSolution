using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop.part_three_q3
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}

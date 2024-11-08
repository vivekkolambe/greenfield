using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty
{
    public delegate void Operation(float factor);       // Object Oriented Function Pointer
    public static class PenaltyHandler
    {
        public static void ServiceDisconnectionPenaltyCharges(float amount)
        {
            Console.WriteLine("Disconnection charges Applied = " + amount);
        }
        public static void NotificationPenaltyCharges(float amount)
        {
            Console.WriteLine("Notification Charges Applied = " + amount);
        }
    }
}

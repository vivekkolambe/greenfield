using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxation
{
    public delegate void Operation(float factor);       // Object Oriented Function Pointer
    public static class TaxHandler
    {
        public static void PayIncomeTax(float factor)
        {
            //
            Console.WriteLine("Income Tax " + factor + " is Deducted From Your Account");
        }
        public static void PayServiceTax(float factor)
        {
            //
            Console.WriteLine("Service Tax " + factor + "  is Deducted From Your Account");
        }
        public static void PayGST(float factor)
        {
            //
            Console.WriteLine("GST " + factor + "  is Deducted From Your Account");
        }
        public static void PayProfesionalTax(float factor)
        {
            //
            Console.WriteLine("Professional " + factor + "  is Deducted From Your Account");
        }
    }
}

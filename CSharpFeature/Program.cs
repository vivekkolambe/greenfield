using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Taxation;
using Proxy;
using Penalty;
namespace CSharpFeature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Creation
            Account acct = new Account(15000);

            //Event Registration
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenaltyCharges;
            acct.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            Console.WriteLine("\n\n\t#########  Withdrawing 8000  from your Account ##########\n");

            acct.Withdraw(8000);
            Console.WriteLine("Available Balance : " + acct.Balance);

            acct.overBalance += TaxHandler.PayProfesionalTax;
            acct.overBalance += TaxHandler.PayIncomeTax;
            acct.overBalance += TaxHandler.PayGST;
            acct.overBalance += TaxHandler.PayServiceTax;
            Console.WriteLine("\n\n\t#########  Depositing 500000000  to your Account ##########\n");
            acct.Deposit(500000000);
            Console.WriteLine("Available Balance : " + acct.Balance);




            Console.ReadLine();
        }
    }
}

//CompileTime, Early Binding, Static Linking
//Handler.PayGST();
//Handler.PayIncomeTax();
//Handler.PayProfesionalTax();
//Handler.PayServiceTax();

/*Operation opn1 = new Operation(Handler.PayServiceTax);
Operation opn2 = new Operation(Handler.PayIncomeTax);
Operation opn3 = new Operation(Handler.PayProfesionalTax);

Operation masteroperation = null;
masteroperation += opn1;
masteroperation += opn2;
masteroperation += opn3;

masteroperation.Invoke(30);

//Dechaining
masteroperation -= opn3;
masteroperation.Invoke(30);
//opn1.Invoke(30);
//opn2.Invoke(30);
//opn3.Invoke(30);
*/
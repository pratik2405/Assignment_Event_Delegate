using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Event_Delegate
{
    //Create a Bank a class, with Debit & Credit method
    //You can assign a default balance using constructor
    //Credit method will accept the amount that needs to be added in balance
    //Debit method will accept the amount that needs to be deducted from the balance.
    //If amount is greater than balance raise an event → insufficient balance
    //If balance is low (< 3000) raise an event low balance
    //If balance is zero then raise an event zero balance.

    public delegate void DisplayTransection();
    public class Program
    {
        static void SuccessfulMsg()
        {
            Console.WriteLine("Transaction is Successfull");
        }
        static void InsufficientBalMsg()
        {
            Console.WriteLine("Balance is insufficient");
        }
        static void LowBalMsg()
        {
            Console.WriteLine("Minimum 3000 balance is required ! ");
            Console.WriteLine("Low Balance !");
        }
        static void ZeroBalMsg()
        {
            Console.WriteLine("Balance is Zero/0");
        }
        static void Main(string[] args)
        {
            Bank b1 = new Bank(0);
            b1.Successful += new DisplayTransection(SuccessfulMsg);
            b1.LowBal += new DisplayTransection(LowBalMsg);
            b1.InsufficientBal += new DisplayTransection(InsufficientBalMsg);
            b1.ZeroBal += new DisplayTransection(ZeroBalMsg);

            //b1.Credit(2000);

            //b1.Debit(1000);
        }
    }
}

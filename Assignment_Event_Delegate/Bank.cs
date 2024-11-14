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
    public class Bank
    {
        private int bal;
        public event DisplayTransection Successful;
        public event DisplayTransection InsufficientBal;
        public event DisplayTransection LowBal;
        public event DisplayTransection ZeroBal;

        public Bank(int bal)
        {
            this.bal = bal;    
        }

        public void Credit(int amt)
        {
            bal = bal + amt;
        }

        public void Debit(int amt)
        {
            if(bal == 0)
            {
                ZeroBal();
            }
            else if ( bal - amt < 3000)
            {
                bal = bal - amt;
                InsufficientBal();
            }
            else if (amt > bal)
            {
                LowBal();
            }
            else
            {
                bal = bal - amt;
                Successful();
            }
            
        }
    }
}

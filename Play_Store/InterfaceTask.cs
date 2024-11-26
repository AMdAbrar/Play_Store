using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Store
{
    public class Bank
    {
        public void canara()
        {
            Console.WriteLine("canara");
        }
        public void SBI()
        {
            Console.WriteLine("SBI");

        }
        public void HDFC()
        {
            Console.WriteLine("HDFC");

        }

    }
    public interface IAccount
    {
        void Deposit();


         void Withdraw();


         void Calculate_interest();


         void View_Balance();
        

    }
    public class Savingsaccount : IAccount
    {
        public void Calculate_interest()
        {
            Console.WriteLine("canara");
        }

        public void Deposit()
        {
            Console.WriteLine("canara");

        }

        public void View_Balance()
        {
            Console.WriteLine("canara");

        }

        public void Withdraw()
        {
            Console.WriteLine("canara");

        }
        public void A_No()
        {
            Console.WriteLine("Account_number");
        }
    }
    public class Currentaccount : IAccount
    {
        public void Calculate_interest()
        {
            Console.WriteLine("Account_number2");

        }

        public void Deposit()
        {
            Console.WriteLine("Account_number2");

        }

        public void View_Balance()
        {
            Console.WriteLine("Account_number2");

        }

        public void Withdraw()
        {
            Console.WriteLine("Account_number2");

        }
        public void A_No2()
        {
            Console.WriteLine("Account_number2");
        }
    }

}

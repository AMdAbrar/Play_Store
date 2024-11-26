using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface
//Interface we will just declare not implementation but in 10.0 version we can implement also
//interface name should be capes always
//we not create object for interface and abstract
//it will hide the crenditial it will just take interface method declaretion 
namespace Play_Store
{
   
    internal interface IPayment
    {
       
        void MakePayment(int acno, int amount);
        void PaymentStatus(int transactionNo);
        void CancelPayment();

    }
    internal interface IBranch
    {
       
        void CancelPayment();

    }
    public class SBI : IPayment, IBranch // here we can implement multiple interface
    {
        public void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }
    }
    public class HDFC : IPayment
    {
        public void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }
    }
    class A { 
    }
    class B {
    }
    class C : B, IBranch//here we cannot implement multiple class but we can implement interface multiple
    {
        public void CancelPayment()
        {
            throw new NotImplementedException();
        }
    }


}

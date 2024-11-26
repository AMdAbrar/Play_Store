using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Store
{
    public abstract class AbstractTask
    {
        public abstract void deposit();
        public abstract void withdraw();
        
        public  void Mandetri()
        {
            Console.WriteLine("RBI");
        }
        

    }
    public class SavingsAccount : AbstractTask
    {
        public override void deposit()
        {
            Console.WriteLine("RBI SAv");

        }

        public override void withdraw()
        {
            throw new NotImplementedException();
        }
    }
    public class CurrentAccount : AbstractTask
    {
        public override void deposit()
        {
            Console.WriteLine("RBI CAC");

        }

        public override void withdraw()
        {
            throw new NotImplementedException();
        }
    }
}

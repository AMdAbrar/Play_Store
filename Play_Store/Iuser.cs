using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface we will just declare not implementation but in 10.0 version we can implement also
//interface name should be capes always
//we not create object for interface and abstract
//it will hide the crenditial it will just take interface method declaretion 
namespace Play_Store
{
    public interface Iuser
    {
        void AddUser();
        void Updateuser();
        void Deleteuser();
        void GetUser();
    }
}

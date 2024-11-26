using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Store
{
    public class User:Iuser  // to inherit we use : instead of implement and extend
    {
        //public int id; //variable

        public int id { get; set; } //property
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long Mobile{get; set;}
        private int UserKey { get; set; }

        public void AddUser()
        {
            //throw new NotImplementedException();
        }

        public void CreateUser() //Functions //syntax=public return/no-return MethondName
        {
            Console.WriteLine("User Registration");
            // how to take input from user
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("welcome," + name);
            email = Console.ReadLine();
            Console.WriteLine("Email:" + email);
            Mobile =long.Parse( Console.ReadLine());//type coverstion using pare method
            Console.WriteLine("mobile:" + Mobile);
            Mobile=Convert.ToInt32(Console.ReadLine()); //type coverstion using covert method
            Console.WriteLine("mobile:" + Mobile);
            //int a=10;
            //string b=a.tostring;

        }

        public void Deleteuser()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void Updateuser()
        {
            throw new NotImplementedException();
        }
    }
}

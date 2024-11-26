using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Store
{
    public class Categories
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        //Constructor:
        //Class name and method name should be same
        //it will trigger automatically when object created.

        public Categories() { }
        public Categories(int id, string name, string description) {

            Id = id;
            Name = name;
            Description = description;
        }
        public void AddCategories(int id, string name) {
            Console.WriteLine("Categories:" + id + "," + name);
        }
        public void AddCategories(int id, string name, string description) {
            Console.WriteLine("Categories:" + id + "," + name+","+description);
            AddCategories(id, name);
        }



    }

    }

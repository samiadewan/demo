using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvanceTopic.OOP
{
    //Constructor example
    public class Customer
    {
        //Multiple constructor example
        public int Id;
        public string Name;
        // public List<Order> Orders;
        public Customer()
        {
            //Orders = new List<Order>();//empty list
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}

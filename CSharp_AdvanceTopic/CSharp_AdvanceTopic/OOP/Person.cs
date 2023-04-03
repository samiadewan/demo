using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvanceTopic.OOP
{
    public class Person
    {
        public string _firstName;
        public string _lastName;
        public string group;

        public Person()
        {
            _firstName = "Devid";
            _lastName = "Crown";
            group = "Science";
        }
        public void GroupName()
        {
            Console.WriteLine($"I am from {group} background");
        }


    }
}

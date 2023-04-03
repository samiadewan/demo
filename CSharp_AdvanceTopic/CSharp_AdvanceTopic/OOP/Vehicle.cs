using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvanceTopic.OOP
{
    //Show constructor inheritance
    public class Vehicle
    {
        private readonly string _registration;
        public int Id;
        /*public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");

        }*/

        public Vehicle(string registration)
        {
            _registration = registration;
            Console.WriteLine($"Vehicle registration number is: {_registration}");
        }
    }
}

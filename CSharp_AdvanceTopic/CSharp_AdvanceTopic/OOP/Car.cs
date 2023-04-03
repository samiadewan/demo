using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvanceTopic.OOP
{
    //Show constructor inheritance
    public class Car : Vehicle
    {
        public Car(string registrationNumber) 
            : base(registrationNumber)
        {
            Console.WriteLine($"Car registration number is: {registrationNumber}");
        }
        
    }
}

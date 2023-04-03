using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AdvanceTopic.OOP
{
    //Declare a class and with different type of access modifier (propertise+method)

    public class Student : Person
    {
        public string nickName { get; set; }
        public int Id { get; set; }
        public int result;
        /*public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }*/
        private void Adress()
        {
            Console.WriteLine("Mirpur 12");
        }
        public void Information()
        {
            Console.WriteLine($"Hi my name is {nickName}");
            Adress();
            //GroupName();// Inheritance 
        }

    }
}

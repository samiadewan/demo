using CSharp_AdvanceTopic.OOP;
using System;
namespace CSharp_AdvanceTopic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Constructor example
            var customer = new Customer(1, "Alice");
            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");

            //Declare a class and with different type of access modifier (propertise+method)
            var students = new Student()
            {
                nickName = "Bob",
                Id = 1
            };

            students.result = 560;
            students.Information();
            Console.WriteLine(students.result);

            //Show different type of class inheritance
            students.GroupName();

            //Show constructor inheritance
            var car = new Car("ZXE875");


        }
    }
}
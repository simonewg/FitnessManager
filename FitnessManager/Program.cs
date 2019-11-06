using System;

namespace FitnessManager.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("mario", "rossi", 20);
            c1.Age = 19;
            Customer c2 = new Customer("Giorgio","Gori",1.75,70,Gender.Male,25,DateTime.Now,"DDK519554");
            Console.WriteLine(c2.ToString());
        }
} }

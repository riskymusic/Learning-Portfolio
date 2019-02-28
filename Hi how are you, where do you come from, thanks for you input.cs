using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static int Country { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, How old are you: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age: " + age);






            Console.WriteLine();
            Console.WriteLine("Where do you come from: ");
            string name = (Console.ReadLine());
            Console.WriteLine("City: " + name);
       
            Console.WriteLine("\nThanks for your input, we will get back to you shortly.", Country);
            Console.ReadLine();

        }
    }
}

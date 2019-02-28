using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Name:" +
                "\n");
            string name = (Console.ReadLine());
         
            Console.WriteLine("\nPlease Enter Your Last Name:" +
                "\n");
            string Name = (Console.ReadLine());
            
            Console.WriteLine("\nhello {0}, nice to meet you" +
                "\n", name + " " + Name);

            Console.WriteLine("What Gender are you:" + "\n");
            string gender = Console.ReadLine();

            Console.WriteLine("\nYou are " + gender);
          

            Console.WriteLine("\nwhat is your age:" + "\n");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYou are:" + age);

            Console.WriteLine("\nwhat is your address:" + "\n");
            string address = Console.ReadLine();

            Console.WriteLine("\nYou live at the address of:" + address);
            

            Console.ReadLine();

            


            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
               
            Console.WriteLine("Hello, " + name);
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are looking good!");
            }
            else
            {
                Console.WriteLine("You're looking a little haggard. Go back to bed");
            }
        }
    }
}

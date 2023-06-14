using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("This is a new message.");
            
            Console.WriteLine("This is a message before loop.");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Line " + i);
            }

            Console.WriteLine("Finished writing lines.");


            Console.ReadLine();
        }
    }
}

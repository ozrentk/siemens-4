﻿using ConsoleApp1.Services;
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
			      Console.WriteLine("This is a new message from branch falak.");	

            Console.WriteLine("This is a new message from Marjan Cuk.");

            LoopingService.DoLoop(15);

            EmailingService.SendEmail("test@test.xyz", "Testing message", "This is a short testing message.\nThank you.");

            Console.WriteLine("Finished writing lines.");

            Console.ReadLine();
        }
    }
}

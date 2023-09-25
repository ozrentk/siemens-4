using ConsoleApp1.Services;
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
            ConfigurationService.Configure("URL", "https://www.google.com");
            ConfigurationService.Configure("ConnectionString", "Server=.;Database=myDataBase;Trusted_Connection=True;");
            Console.ReadLine();
        }
    }
}

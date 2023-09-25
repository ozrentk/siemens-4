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
        /// <summary>
        /// Ovo je programčić
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConfigurationService.Configure("URL", "https://www.google.com");
            ConfigurationService.Configure("ConnectionString", "Server=.;Database=myDataBase;User=[USERNAME-HERE];Password=[PASSWORD-HERE]");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            ConfigurationService.Configure("URL2", "https://github.com/");
            Console.ReadLine();
        }
    }
}

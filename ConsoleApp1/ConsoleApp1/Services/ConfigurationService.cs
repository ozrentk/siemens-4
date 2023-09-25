using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public static class ConfigurationService
    {
        public static void Configure(string name, string value)
        {
            Console.WriteLine($"Config: {name}={value}");
        }
    }
}

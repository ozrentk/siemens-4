using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public static class LoopingService
    {
        public static void DoLoop(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Line " + i);
            }
        }
    }
}

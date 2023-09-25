using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public static class EmailingService
    {
        /// <summary>
        /// This sends email
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public static void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"---");
            Console.WriteLine($"Sending email to {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"--- Body ---");
            Console.WriteLine(body);
            Console.WriteLine($"---");
        }
    }
}

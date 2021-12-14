using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            string userName = Console.ReadLine();

            DateTime data = DateTime.Now;

            Console.WriteLine($"Привет {userName}, сегодня  {data}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] clock = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine(clock[i % clock.Length]);

                
            }
            Console.ReadKey();
        }
    }
}
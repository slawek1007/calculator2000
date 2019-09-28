using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3000
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menuOption = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("0. Exit");
                if (menuOption == 0)
                {
                    break;
                }
                Console.WriteLine("1. ADD");
                if (menuOption == 1)
                {

                }
                Console.WriteLine("2. DIFF");
                if (menuOption == 2)
                {

                }
            }
        }
    }
}

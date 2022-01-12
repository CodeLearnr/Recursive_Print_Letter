using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Print_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== LA 26 - Recursive Print Letters ====\n");
            bool validEntry = false;
            int n;
            while (!validEntry)
            { 
                Console.Write("How many letters do you want to print? ");
           
                bool success = int.TryParse(Console.ReadLine(), out n);

                if(success)
                {
                        if ( n > 26 || n < 1)
                        {
                            Console.WriteLine("\nPlease enter a number between 1 to 26.");
                        }
                        else
                        {
                                validEntry = true;
                                Letter(n);
                        }
                }
                else
                    Console.WriteLine("\nPlease enter a valid number.");

            }
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();
        }

        public static void Letter(int m)
        {
            char a = Convert.ToChar(m + 64);
            
            if (m > 0)
            {
                Letter(m - 1);
                Console.Write(a + " ");
            }
        }

    }
}

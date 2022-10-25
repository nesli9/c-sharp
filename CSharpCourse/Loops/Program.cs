using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEach();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine ("this isnt a prime number");
            }
            
            
            

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i ==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }




        private static void ForEach()
        {
            string[] students = new string[3] { "engin", "derin", "salih" };
            foreach (var student in students)//forech read only durumundadır.
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is {0} ", number);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished");
        }
    }
}

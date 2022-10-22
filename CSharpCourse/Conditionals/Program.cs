using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            //if - else bloğu
            //if (number == 10)
            //{
            //    Console.WriteLine("number is 10");

            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("number is20");
            //}
            //else
            //{
            //    Console.WriteLine("number is'nt 10 or 20");
            //}

            //switch-case bloğu
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("number is 10");
            //        break;

            //    case 20:
            //        Console.WriteLine("number is20");
            //        break;
            //    default:
            //        Console.WriteLine("number is'nt 10 or 20");
            //        break;

            //}

            //Console.WriteLine(number == 10 ? "number is 10" : "number isnt 10"); //tek satırda şart işlemi

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("number is between 0-100");
            //}
            //else if (number >100 && number <= 200)
            //{
            //    Console.WriteLine("number is between 101-200");
            //}
            //else if(number > 200 || number < 0)
            //{
            //    Console.WriteLine("number is less then 0 or greater then 200");
            //}
            
            if (number <100)
            {
                if (number >= 90 && number <95)
                {
                    Console.WriteLine("number is between 90-95");
                }
            }





            Console.ReadLine();
        }
    }
}

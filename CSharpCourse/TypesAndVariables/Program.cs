using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            //Console.WriteLine("hello world");
            
            
            double number5 = 10.4;
            decimal number6 = 10.2m;
            char character = 'A';
            bool condition = true;
            byte number4 = 254; //8 bit
            short number3 = 32767; //16 bit
            int number1 = 10; //int tipinin alabileceği değer aralığı --> alt sınır : -2147483648  , üst sınır :2147483647 dir .(32 bit)
            long number2 = 2147483647; //64 bit
            var number7 = 10;
            number7 = 'A';
            

            Console.WriteLine("Number1 is {0}", number1); //{0} : index başlangıcını belirtir
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);

            Console.ReadLine(); //kullanıcının herhangi bir tuşa basılması beklenir.

        }
    }
     enum Days 
      {
        Monday , Tuesday, Wednesday,Thursday , Friday, Saturday,Sunday
      }

}

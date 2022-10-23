using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "engin", "derin", "salih" };
            //students[0] = "engin";
            //students[1] = "derin";
            //students[2] = "salih";

            //string[] students2 = new [] {"engin" , "derin" , "salih"};
            string[] students2 = { "engin", "derin", "salih" };

            foreach (var student in students2)
            {
                //Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "istanbul","izmit","balıkesir"},
                { "akara","konya","kırıkkale"},
                { "antalya","adana","mersin"},
                { "rize","trabzon","samsun"},
                { "izmir","muğla","manisa"}
                
            };
            //regions[0, 0] = "istanbul";

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************");
            }

            //Console.WriteLine();
            Console.ReadLine();

        }

    }
}

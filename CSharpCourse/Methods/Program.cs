using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);
            //var result = Add2(20,30);

            //int number1 = 20;
            //int number2 = 100;
            ////var result2 = Add3(number1,number2);
            ////var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine("result is : " + result2);
            //Console.WriteLine("number1 is : " +number1);

            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Multiply2(2, 4,5));

            Console.WriteLine(Add4(1,2,3,4,5));
            Console.ReadLine();

        }
        static void Add() // void : git şunu yap demektir . bir yere kayıt yap , bir yere şunu yaz demektir.
        {
            //Console.WriteLine("added!");
            
        }
        static int Add2(int number1 , int number2=30) //int number2 = 30 : default değeri atanır eğer number2 değeri yazılmazsa default(varsayılan) olarak 30 değerini yaz demektir.
        //default değerler her zaman metodun sonunda olmalıdır.
        {
            //return number1 + number2;
            var result = number1 + number2;
            return result;
        }
        //static int Add3(int number1 , int number2)
        //static int Add3( ref int number1, int number2) //ref : referance tiptir . iki değişken tanımlamak yerine number1 ın referansını kullanmaktır. 
        static int Add3(out int number1, int number2) // out : ref gibidir. farkı ref te number1 değeri mutlaka set edilmiş(değeri olmalı ) olmalı ama out ta gerek yoktur.
        //out ta methodun içinde 1 kere set edilmiş olması yeterlidir .
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1 , int number2)
        {
            return number1 * number2;
        }
        static int Multiply2(int number1, int number2,int number3)
        {
            return number1 * number2 *number3;
        }
        static int Add4(params int[] numbers)//params'la methoda aynı tipte istenildiği kadar parametre gönderilebilir
        {
            return numbers.Sum();
        }

    }
}

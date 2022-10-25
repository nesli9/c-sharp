using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings //string = char array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "my name is engin";

            var result = sentence.Length; //karakter uzunluğu
            var result2 = sentence.Clone(); //nesnenin kopyasını oluşturur
            bool result3 = sentence.EndsWith("n"); //nesnenin son karakteri verilen değer mi diye kontrol yapılır.
            bool result4 = sentence.StartsWith("n");
            var result5 = sentence.IndexOf("name"); //string te belli bir karakteri veya kelimeyi aramak için kullanılır.
            var result6 = sentence.IndexOf(" "); //bulduğu ilk değerin indexini yazdırır. && aramaya baştan başlar
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar
            var result8 = sentence.Insert(0,"hello, "); //string ekleme
            var result9 = sentence.Substring(3,4); //metni parçalar && girilen değerden itibaren consolda gösterir.(3 (ten itibaren) , 4(tane karakter alır))
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "_"); //yeniden yaz --> örenekte boşluklar yerine alt çizgi yazılarak değiştirildi
            var result13 = sentence.Remove(2,4); //belli indexten sonrası atilir.


            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "istanbul";

            //string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}

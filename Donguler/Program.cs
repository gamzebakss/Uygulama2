using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Pogramlamaya Başlancıç Temel Kursu";
            string kurs3 = "Java Kursu";//bu tip verileri böyle değilde array-dizi tutarız.Aşağıdaki gibi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Pogramlamaya Başlancıç Temel Kursu" , "Java Kursu","Python Kursu","C#" };//böyle Yapmamız lazım bu şekilde birden fazla string tutabiliriz.


            for (int i = 0; i < kurslar.Length; i++)//kurslar.Length yazmamızın sebebi dinamik bir döngü sağlamak kaçtane kurs varsa ona göre dönecek
            {
                Console.WriteLine(kurslar[i]);
            }
                Console.WriteLine("For Bitti");

            //Farklı Bir döngü yöntemi denicez aşağıda
            foreach (string kurs in kurslar)//dizi temlelli yapıları tek tek dönmeye yarıyor.For döngüsü yerine buda yazılabilir.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}

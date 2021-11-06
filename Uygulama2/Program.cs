using System;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagoriEtiketi = ("Kategoriler");
            int ogrenciSayisi = 32000;
            double faizOrani=1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBungun = 7.45;

            Console.WriteLine(katagoriEtiketi);

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            if (dolarDun>dolarBungun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBungun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

           
          
        }
    }
}

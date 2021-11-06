using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();//Bir class değişkeni tanımladık
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();//Bir class değişkeni tanımladık
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Gamze Bakış";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();//Bir class değişkeni tanımladık
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Emre Bakış";
            kurs3.IzlenmeOrani = 100;


            // Console.WriteLine(kurs1.KursAdi+":"+kurs1.Egitmeni);//Böylede yazılıyor dinamik değil ama

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};//Yazdırma ve döngüsü böyle sağlanıyor

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmeni+"="+kurs.IzlenmeOrani);
            }
           
        }
    }

    class Kurs//Bir class kurduk 
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

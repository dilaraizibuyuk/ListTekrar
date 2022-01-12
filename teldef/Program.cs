using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teldef
{
    class Program
    {
        static void Main(string[] args)
        {
            List<rehber> kisiListesi = new List<rehber>();
            rehber yenikisi1 = new rehber();
            rehber yenikisi2 = new rehber();
            rehber yenikisi3 = new rehber();

            yenikisi1.Ad = "Ahmet";
            yenikisi1.Soyad = "Can";
            yenikisi1.Telefon = "050555554";

            yenikisi2.Ad = "Ali";
            yenikisi2.Soyad = "Aydın";
            yenikisi2.Telefon = "13213546541";


            yenikisi3.Ad = "Serdar";
            yenikisi3.Soyad = "Kaymaz";
            yenikisi3.Telefon = "875154";

            kisiListesi.Add(yenikisi1);
            kisiListesi.Add(yenikisi2);
            kisiListesi.Add(yenikisi3);

            //Diğer Ekleme Yöntemi
            kisiListesi.Add(new rehber()
            {
                Ad = "Halil",
                Soyad = "Çan",
                Telefon = "5454545"
            });
            //Listeden Silme
            kisiListesi.Remove(yenikisi3);

            for (int i = 0; i < kisiListesi.Count; i++)
            {
                Console.WriteLine(kisiListesi[i].Ad + "\t" + kisiListesi[i].Soyad + "\t" + kisiListesi[i].Telefon);
            }
            Console.ReadKey();
        }
    }
}

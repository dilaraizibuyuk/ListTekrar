using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> yazarlar = new List<string>();
            yazarlar.Add("Cemal Süreya");
            yazarlar.Add("Fyodor Dostoyevski");
            yazarlar.Add("Turgut Uyar");
            yazarlar.Add("Oğuz Atay");

            Console.WriteLine();
            foreach (string yazar in yazarlar)
            {
                Console.WriteLine(yazar);
            }
            Console.WriteLine("Listedeki yazar sayısı:{0}",yazarlar.Count);
            Console.ReadKey();


        }
    }
}

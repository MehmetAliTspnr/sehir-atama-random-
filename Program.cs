using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sehir_Atama_Programı
{
    internal class Program//OGRETMEN SEHİR ATAMASI
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine(":::Sehir Atama Programi:::");
            string[] sehirler = { "Ankara", "Bursa", "Adana", "Hatay", "İstanbul", "Antalya", "İzmir" };
            Random rastgele=new Random();
            a = rastgele.Next(0, sehirler.Length);// dizinin uzunlugu kadar maksimum değer üretecek.
            Console.WriteLine(a+"-"+sehirler[a]);
      
            Console.Read();
            

        }
    }
}

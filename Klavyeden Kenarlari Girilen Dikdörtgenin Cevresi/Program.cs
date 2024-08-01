using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Kenarlari_Girilen_Dikdörtgenin_Cevresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kisaKenar, uzunKenar, cevre;

            Console.WriteLine(" dikdöertgenin kısa kenarını giriniz ");
            kisaKenar = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" dikdöertgenin uzun kenarını giriniz ");
            uzunKenar = Int32.Parse(Console.ReadLine());


            cevre = kisaKenar + uzunKenar + kisaKenar + uzunKenar;
            // cevre = (kısakenar * uzunkenar)*2

            Console.WriteLine("Dikdörtgenin Çevresi = {0}", cevre);
            Console.ReadLine();




        }
    }
}

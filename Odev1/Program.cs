using System.Threading.Channels;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(" *** Hoşgeldiniz... *** ");
                Console.WriteLine(" ");

                try
                {
                    

                    Console.WriteLine("Lütfen birinci sınav notunu giriniz...");
                    int birinciNot = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen ikinci sınav notunu giriniz...");
                    int ikinciNot = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen üçüncü sınav notunu giriniz...");
                    int ucuncuNot = Convert.ToInt32(Console.ReadLine());

                
                    int ortalama = (birinciNot + ikinciNot + ucuncuNot) / 3;

                    if (ortalama > 0 && ortalama < 45)
                        Console.WriteLine("Ortalamanız : " + ortalama + "   -->  " + "Harf notunuz : FF");

                    else if (ortalama >= 45 && ortalama < 65)
                        Console.WriteLine("Ortalamanız : " + ortalama + "   -->  " + "Harf notunuz : DD");

                    else if (ortalama >= 65 && ortalama < 75)
                        Console.WriteLine("Ortalamanız : " + ortalama + "   -->  " + "Harf notunuz : CC");

                    else if (ortalama >= 75 && ortalama < 85)
                        Console.WriteLine("Ortalamanız : " + ortalama + "   -->  " + "Harf notunuz : BB");

                    else if (ortalama >= 85 && ortalama < 100)
                        Console.WriteLine("Ortalamanız : " + ortalama + "   -->  " + "Harf notunuz : AA");
                }
                catch (Exception hata)
                {
                    Console.WriteLine("Yanlış değer girdiniz");
                }
                Console.ReadKey();
                
            }

           
        }
    }
}


namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Hesap Makinesi Uygulaması");
            Console.WriteLine("--------------------------\n");


            do
            {
                Console.WriteLine("         MENÜ      \n");
                Console.WriteLine("Toplama işlemi için 1'e basınız.");
                Console.WriteLine("Çıkarma işlemi için 2'ye basınız.");
                Console.WriteLine("Bölme işlemi için 3'e basınız.");
                Console.WriteLine("Çarpma işlemi için 4'e basınız.");
                Console.WriteLine("Çıkmak için 0'a basınız.\n");

                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?\n");

                try
                {
                    int secim;
                    while (!int.TryParse(Console.ReadLine(), out secim))
                    {
                        Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                    }

                    switch (secim)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("TOPLAMA iŞLEMİ");
                            Console.WriteLine("---------------");

                            Console.WriteLine("Lütfen birinci sayıyı giriniz...");
                            decimal sayi1;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi1))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine("Lütfen ikinci sayıyı giriniz...");
                            decimal sayi2;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi2))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine($"Toplama işlemi sonucu : " + (sayi1 + sayi2));


                            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...\n");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 2:
                            Console.Clear();


                            Console.WriteLine("ÇIKARMA iŞLEMİ");
                            Console.WriteLine("---------------");

                            Console.WriteLine("Lütfen birinci sayıyı giriniz...");
                            decimal sayi3;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi3))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine("Lütfen ikinci sayıyı giriniz...");
                            decimal sayi4;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi4))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine($"Çıkarma işlemi sonucu : " + (sayi3 - sayi4));



                            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...\n");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 3:
                            Console.Clear();

                            Console.WriteLine("BÖLME iŞLEMİ");
                            Console.WriteLine("---------------");

                            Console.WriteLine("Lütfen birinci sayıyı giriniz...");
                            decimal sayi5;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi5))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine("Lütfen ikinci sayıyı giriniz...");
                            decimal sayi6;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi6))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine($"Bölme işlemi sonucu : " + (sayi5 / sayi6));

                            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...\n");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 4:
                            Console.Clear();

                            Console.WriteLine("ÇARPMA iŞLEMİ");
                            Console.WriteLine("---------------");

                            Console.WriteLine("Lütfen birinci sayıyı giriniz...");
                            decimal sayi7;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi7))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine("Lütfen ikinci sayıyı giriniz...");
                            decimal sayi8;
                            while (!decimal.TryParse(Console.ReadLine(), out sayi8))
                            {
                                Console.WriteLine("Geçersiz karakter girişi. Lütfen bir sayı giriniz.");
                            }

                            Console.WriteLine($"Çarpma işlemi sonucu : " + (sayi7 * sayi8));

                            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...\n");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        default:
                            while (secim == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Çıkış yapılıyor");
                                return;
                            }

                            break;
                    }
                }
                catch {; }
            }
            while (true);

        }
    }
}

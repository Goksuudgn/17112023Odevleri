namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Lütfen bir renk giriniz... ( Kırmızı - Sarı - Yeşil )");


                string renk = Console.ReadLine();

                switch (renk)
                {
                    case "Kırmızı":
                        Console.Clear();
                        Console.WriteLine("Lütfen Bekleyin\n");
                        Console.WriteLine("Devam etmek için bir tuşa basınız..");
                        break;
                    case "Sarı":
                        Console.Clear();
                        Console.WriteLine("Hazırlanın\n");
                        Console.WriteLine("Devam etmek için bir tuşa basınız..");
                        break;
                    case "Yeşil":
                        Console.Clear();
                        Console.WriteLine("Geçebilirsiniz\n");
                        Console.WriteLine("Devam etmek için bir tuşa basınız..");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı seçim yaptınız\n");
                        Console.WriteLine("Devam etmek için bir tuşa basınız..");

                        break;

                }
                Console.ReadLine();
                
            }
            while (true);

          
        }
    }
}

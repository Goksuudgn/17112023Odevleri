namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                double operand1, operand2;
                string operation;

                do
                {
                    Console.WriteLine("İşlem yapmak için birinci sayıyı girin: ");
                    operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("İşlem yapmak için ikinci sayıyı girin: ");
                    operand2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("İşlem türünü girin (+, -, *, /): ");
                    operation = Console.ReadLine();

                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = operand1 + operand2;
                            Console.WriteLine("Sonuç: " + result);
                            break;
                        case "-":
                            result = operand1 - operand2;
                            Console.WriteLine("Sonuç: " + result);
                            break;
                        case "*":
                            result = operand1 * operand2;
                            Console.WriteLine("Sonuç: " + result);
                            break;
                        case "/":
                            if (operand2 != 0)
                            {
                                result = operand1 / operand2;
                                Console.WriteLine("Sonuç: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Hata! İkinci sayı sıfır olamaz.");
                            }
                            break;
                        default:
                            Console.WriteLine("Hata! Geçersiz işlem türü.");
                            break;
                    }

                    Console.WriteLine("Devam etmek için 'E' tuşuna basın.");
                } while (Console.ReadKey().Key == ConsoleKey.E);
            }
        }

    }



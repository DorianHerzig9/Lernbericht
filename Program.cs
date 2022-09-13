namespace Number_Guesser_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" (¬_¬)                                                                                                                                                                    Random Number Generator                                                                                                                                                                                                                                                                                               ");
            Console.BackgroundColor = ConsoleColor.Black;

            int min = 1;
            int max = 100;
            int number = new Random().Next(min, max);

            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Wählen Sie eine Zahl zwischen " + min + " - " + max + ":");
                Console.ForegroundColor = ConsoleColor.Green;
                int Zahleingabe = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Random rnd = new Random();

                while (Zahleingabe != number)
                {
                    if (Zahleingabe > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Ihre Zahl ist zu gross.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Ihre Zahl ist zu klein.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(" Geben sie erneut eine Zahl ein: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Zahleingabe = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    if (Zahleingabe == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Glückwunsch Sie haben die richtige Zahl gefunden.");
                        Console.ForegroundColor = ConsoleColor.White;

                    }


                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                Console.ForegroundColor = ConsoleColor.White;
                decimal
            }


        }


    }
}


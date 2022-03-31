using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            int user = 0;
            bool valid = false;
            int i = 0;
            bool[] array = new bool[10];

            Console.Title = "Zgadnij liczbę"; // zmiana nazwy okna
            Console.ForegroundColor = ConsoleColor.Yellow; // zmiana koloru konsoli
            Console.WriteLine("Zgadnij liczbę od 1 do 10! \n");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.Write("Podaj liczbę:");
                    valid = int.TryParse(Console.ReadLine(), out user); // pobranie liczby, sprawdzenie czy podal liczbę, to zwraca typ bool,                                                 // wartosc jako int zapisywana do zmiennej user

                    if (!valid) // sprawdzenie czy to liczba, jeżeli valid jest false
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podaj prawidłową liczbę! \n");
                        Console.ResetColor();
                    }
                } while (!valid);

                if (user < 1 || user > 10) // sprawdzenie czy liczba jest w badanym zakresie
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podaj liczbę z zakresu 1-10! \n");
                    Console.ResetColor();
                    continue;
                }
                if (array[user - 1]) // sprawdzenie czy użytkownik nie podawał juz przypadkiem tej liczby
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podano tą samą liczbę! \n");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    array[user - 1] = true;
                }

                if (random < user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest mniejsza od twojej! \n");
                    Console.ResetColor();
                }
                else if (random > user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest większa od twojej! \n");
                    Console.ResetColor();
                }
                i++; // zliczanie liczby podejsc
            } while (user != random);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo!!! Odgadłeś za {i} razem \n");
            Console.ResetColor();
            Console.ReadKey();
            
        }
    }
}

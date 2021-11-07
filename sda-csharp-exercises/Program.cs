using System;

namespace sda_csharp_exercises
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                Cwiczenie1();
            }

            static void Cwiczenie1()
            {
                Console.Write("Podaj cenę produktu: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj liczbę linii: ");
                int linesCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= linesCount; i++)
                {
                    Console.WriteLine($"Liczba sztuk: {i} łączna cena: {price * i}zł");
                }
            }
        }
    }
}
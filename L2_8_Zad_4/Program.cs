using System;

namespace L2_8_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program po podaniu liczby całkowitej wyświetli piramidę liczb.");
            
            Console.Write("Podaj liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out int inputNumber);

            int counter = 1;

            for (int i = 1; counter <= inputNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (counter <= inputNumber)
                    {
                        Console.Write(counter + " ");
                    }
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}

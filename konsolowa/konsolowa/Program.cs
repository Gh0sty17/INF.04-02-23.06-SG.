using System;

namespace KonsolaSortowanie
{
    class Program
    {
        static void SortowanieBabelkowe(int[] tablica)
        {
            int rozmiar = tablica.Length;
            for (int i = 0; i < rozmiar - 1; i++)
            {
                for (int j = 0; j < rozmiar - 1 - i; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int bufor = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = bufor;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            const int ROZMIAR_TABLICI = 100;
            int[] liczby = new int[ROZMIAR_TABLICI];
            Random random = new Random();

            for (int i = 0; i < ROZMIAR_TABLICI; i++)
            {
                liczby[i] = random.Next(1001);
            }
   
            Console.WriteLine("=== uruchomienie testu funkcji sortującej ===");
            SortowanieBabelkowe(liczby);

            bool czyPosortowana = true;
            for (int i = 0; i < ROZMIAR_TABLICI - 1; i++)
            {
                if (liczby[i] > liczby[i + 1])
                {
                    czyPosortowana = false;
                    break;
                }
            }

            if (czyPosortowana)
            {
                Console.WriteLine("TEST POZYTYWNY: Tablica została poprawnie posortowana rosnąco.");
            }
            else
            {
                Console.WriteLine("TEST NEGATYWNY: Tablica NIE jest poprawnie posortowana!");
            }
            Console.WriteLine();

         
            Console.WriteLine("=== Posortowana tablica 100 liczb ===");
            for (int i = 0; i < ROZMIAR_TABLICI; i++)
            {
                Console.Write(liczby[i]);
                if (i < ROZMIAR_TABLICI - 1)
                {
                    Console.Write(", "); 
                }
            }
            Console.WriteLine();
        }
    }
}
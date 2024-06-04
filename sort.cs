using System;

class Program
{
    static void Main(string[] args)
    {
        // Krok 1: Pobranie od użytkownika rozmiaru tablicy
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        // Krok 2: Generowanie tablicy losowych liczb
        Random rand = new Random();
        int[] tablica = new int[rozmiar];
        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(0, 101);
        }

        // Krok 3: Wyświetlenie tablicy przed sortowaniem
        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (var item in tablica)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Krok 4: Sortowanie tablicy za pomocą algorytmu sortowania przez wybór
        for (int i = 0; i < rozmiar - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < rozmiar; j++)
            {
                if (tablica[minIndex] > tablica[j])
                {
                    minIndex = j;
                }
            }

            // Zamiana elementów
            int temp = tablica[minIndex];
            tablica[minIndex] = tablica[i];
            tablica[i] = temp;
        }

        // Krok 5: Wyświetlenie tablicy po sortowaniu
        Console.WriteLine("\nTablica po sortowaniu:");
        foreach (var item in tablica)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

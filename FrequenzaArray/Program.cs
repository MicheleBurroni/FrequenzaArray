using System;
using libreria;

namespace FrequenzaArray
{
    class Program
    {
        const int NUM = 10;
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci 10 valori: ");
            int x = int.Parse(Console.ReadLine());
            int[] arrayInteri = new int[x];
            Gestione.RiempiArray(arrayInteri);
            Gestione.BubbleSort(arrayInteri);
        }                                
    }
}

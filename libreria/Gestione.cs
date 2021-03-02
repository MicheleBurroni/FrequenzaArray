using System;

namespace libreria
{
    public class Gestione
    {
        public static void BubbleSort(int[] n)
        {
            int x, y;
            int temp;
            for (x = 0; x < n.Length - 1; x++)
            {
                for (y = 0; y < n.Length - 1 - x; y++)
                {
                    if (n[y] > n[y + 1])
                    {
                        temp = n[y];
                        n[y] = n[y + 1];
                        n[y + 1] = temp;
                    }
                }
            }
        }
        public static void RiempiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

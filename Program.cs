using System;

namespace BubbleSort
{
    class Program
    {
        public static void Bubblsort(int[] arr)
        {
            int temp;
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 20, 5, 8, 9, 11 };
            Program.Bubblsort(array);
            for(int i=0;i<array.Length;i++)
            Console.WriteLine(""+array[i]);
        }
    }
}

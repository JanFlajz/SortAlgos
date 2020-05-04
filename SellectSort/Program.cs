using System;

namespace SellectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 1, 3, 5, 34, 74, 45, 69, 16, 11, 13, 8 };

            ArrayOutPut(arr);

            SelectSortAsc(arr);

            ArrayOutPut(arr);


            Console.ReadKey();
        }

        // Ascending
        private static void SelectSortAsc(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {

                    if (arr[j] < arr[min])
                    {
                        min = j;
                        // In´the descending cas, we just change < with >
                    }



                }
                Swap(arr, min, i);

            }
        }

        private static void Swap(int[] arr, int min, int i)
        {
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }

        private static void ArrayOutPut(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

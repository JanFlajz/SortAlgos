using System;

namespace QuickSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 1, 3, 5, 34, 74, 45, 69, 16, 11, 13, 8 };
            int left = 0;
            int right = arr.Length - 1;

            OutPutArray(arr);
            Console.WriteLine();
            MyQuickSort(arr, left, right);

            OutPutArray(arr);

            Console.ReadKey();
        }

        private static void MyQuickSort(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            int start = left;
            int end = right;

            while (start <= end)
            {
                while (arr[start] < pivot)
                {
                    start++;
                }
                while (arr[end] > pivot)
                {
                    end--;
                }
                if (start <= end)
                {
                    Swap(arr, start, end);
                    start++;
                    end--;
                }

            }
            if (left < end)
            {
                MyQuickSort(arr, left, end);
            }
            if (right > start)
            {
                MyQuickSort(arr, start, right);
            }



        }

        private static void Swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;


        }

        static void OutPutArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }

        }


    }
}

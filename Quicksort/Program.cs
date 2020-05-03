using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]
                { 1, 6 , 8 , 13 , 52 , 11 , 98 , 22 , 47 , 69 , 420 , 88 , 5 , 3 , 33 , 21 , 33 , 0 ,72 };
            int left = 0;
            int right = arr.Length;


            Writearray(arr);
            Quicksort(arr, left, right);
            Console.WriteLine();
            Writearray(arr);


            Console.ReadLine();
        }

        private static void Writearray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        private static void Quicksort(int[] arr, int left, int right)
        {
            
            if(right > left)
            {
                int pivot = left;
                

                for(int i = left +1; i < right; i++)
                {
                    if(arr[left] > arr[i])
                    {
                        pivot++;
                        SwapValues(pivot, arr, i);
                    }



                }
                SwapPivot(pivot, left, arr);

                Quicksort(arr, left, pivot);
                Quicksort(arr, ++pivot, right);



            }


            
        }

        private static void SwapValues(int pivot, int[] arr, int i)
        {
            int temp = arr[i];
            arr[i] = arr[pivot];
            arr[pivot] = temp;


        }
        private static void SwapPivot(int pivot, int left, int[] arr)
        {
            int temp = arr[left];
            arr[left] = arr[pivot];
            arr[pivot] = temp;


        }


    }
}

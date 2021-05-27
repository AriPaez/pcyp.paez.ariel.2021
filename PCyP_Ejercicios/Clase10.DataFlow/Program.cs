using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.DataFlow
{
    class Program
    {

        static public int[] order(int [] arr)
        {
            int aux = 0, min = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                //swap
                aux = arr[i];
                arr[i] = arr[min];
                arr[min] = aux;

            }

            return arr;
        }


        static public int binarySearch(int[] arr, int value)
        {

            int der = arr.Length,izq=0;
            int numberOfIterationsInTheWorstCase = (int)(Math.Log(der) / Math.Log(2)) + 1;

            int pivot = 0, cP = 0;
            Boolean located = false;

            while (!located && cP < numberOfIterationsInTheWorstCase)
            {
                pivot = (izq + der) / 2;
                cP++;

                if (value == arr[pivot])
                {
                    located = true;
                }

                if (value < arr[pivot])
                {
                    der = pivot;
                }
                else if (value > arr[pivot])
                {
                    izq = pivot;
                }


            }

            if (located)
            {
                return arr[pivot];
            }
            else
            {
                return -1;
            }
        
    }
       
        static void Main(string[] args)
        {


            int[] arr1 = new int[] { 100, 750, 400, 75, 900, 975, 275, 750, 600, 125, 300 };

            int[] arr2 = new int[] { 12, 750, 0, 75, 432, 76, 0, 750, 600, 213, 300,43,54 };

            int[] arr3 = new int[] { 12, 987, 765, 75, 432, 865, 6543, 876, 9876, 654, 7654 };


            //vector ordering

            Task<int[]> orderArr1 = Task.Factory.StartNew(() => {

                return order(arr1);

            });

            Task<int[]> orderArr2 = Task.Factory.StartNew(() => {

                return order(arr2);

            });

            Task<int[]> orderArr3 = Task.Factory.StartNew(() => {

                return order(arr3);

            });


            //search for values

            int value1 = 750;
            int value2 = 600;
            int value3 = 9876;

            Task<int> valueArr1 = orderArr1.ContinueWith((p) => {

                int result = binarySearch(p.Result, value1);

                if(result == -1)
                {
                    return 0;
                }

                return result;

            });

            Task<int> valueArr2 = orderArr2.ContinueWith((p) => {

                int result = binarySearch(p.Result, value2);

                if (result == -1)
                {
                    return 0;
                }

                return result;

            });

            Task<int> valueArr3 = orderArr3.ContinueWith((p) => {


                int result = binarySearch(p.Result, value3);

                if (result == -1)
                {
                    return 0;
                }

                return result;

            });

            

            Task<int> sum = Task.Factory.ContinueWhenAll<int>(
            new[] { valueArr1, valueArr2, valueArr3 }, (tasks) =>
            {
                     return (valueArr1.Result + valueArr2.Result + valueArr3.Result);
            });

            Console.WriteLine($"Total is : {sum.Result}");

            Console.ReadLine();
        }
    }
}

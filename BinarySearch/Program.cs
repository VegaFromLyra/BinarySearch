using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 3, 5, 7, 9, 11 };

            Console.WriteLine("Test case 1: Is {0} present in input ?: {1}", 7, Find(input, 7));
            Console.WriteLine("Test case 2: Is {0} present in input ? : {1}", 6, Find(input, 6));
        }

        // Find a number in a sorted array
        static bool Find(int[] arr, int num)
        {
            return FindHelper(arr, 0, arr.Length - 1, num);
        }

        static bool FindHelper(int[] arr, int low, int high, int num)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == num)
                {
                    return true;
                }
                else if (num < arr[mid])
                {
                    return FindHelper(arr, low, mid - 1, num);
                }
                else
                {
                    return FindHelper(arr, mid + 1, high, num);
                }
            }

            return false;
        }

    }
}

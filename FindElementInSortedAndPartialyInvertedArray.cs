using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class FindElementInSortedAndPartialyInvertedArray
    {
        public static int findPivot(int[] a, int l, int r)
        {
            if (l > r)
                return -1;
            if (l == r)
                return l;
            int mid = (l + r) / 2;
            if (mid < r && a[mid] < a[mid - 1])
                return mid;
            if (mid < r && a[mid] > a[mid + 1])
                return mid;
            if (a[mid] > a[l])
                return findPivot(a, mid + 1, r);
            return findPivot(a, mid - 1, r);
        }

        public static int binarySearch(int[] a, int l, int r, int num)
        {
            if (l <= r)
            {
                int mid = (l + r) / 2;
                if (a[mid] == num)
                    return mid;
                if (a[mid] > num)
                    return binarySearch(a, l, mid - 1, num);
                else
                    return binarySearch(a, mid + 1, r, num);
            }
            return -1;
        }

        static void Main(string[] args)
        {
			//Search Algorithms
            //Num to search
            int numToSearch = 8;
            //Input array
            int[] a = { 5, 6, 7, 8, 9, 1, 2, 3, 4 };
            //Find pivit which will divide sorted and inverted array
            int pivot = findPivot(a, 0, a.Length - 1);
            //find element in both the subarray
            Console.WriteLine("Element found at index = {0}", Math.Max(binarySearch(a, 0, pivot, numToSearch), binarySearch(a, pivot + 1, a.Length - 1, numToSearch)));
            Console.ReadLine();
        }

    }


}

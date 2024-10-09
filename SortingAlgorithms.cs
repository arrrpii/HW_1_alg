using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public static class SortingAlgorithms
    {
        public static void SelectionSortRecursive(int[] array)
        {
            SelectionSort(array, array.Length, 0);
        }
        public static void SelectionSort(int[] array, int n, int i)
        {

            if (i == n)
            {
                return;
            }
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            int temp = array[min];
            array[min] = array[i];
            array[i] = temp;

            SelectionSort(array, n, i + 1);
        }
    }
}

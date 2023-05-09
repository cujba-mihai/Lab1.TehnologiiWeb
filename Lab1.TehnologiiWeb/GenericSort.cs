using System;

namespace Lab1.TehnologiiWeb
{
    internal class GenericSort<T> where T : IComparable<T>
    {
        public delegate int Comparare(T x, T y);

        public void BubbleSort(T[] array, Comparare comp)
        {
            if (array == null)
            {
                return;
            }
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comp(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void InsertionSort(T[] array, Comparare comp)
        {
            if (array == null)
            {
                return;
            }
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && comp(array[j], key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public void QuickSort(T[] array, Comparare comp)
        {
            if (array == null)
            {
                return;
            }
            QuickSortHelper(array, 0, array.Length - 1, comp);
        }

        private void QuickSortHelper(T[] array, int low, int high, Comparare comp)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high, comp);

                QuickSortHelper(array, low, pivotIndex - 1, comp);
                QuickSortHelper(array, pivotIndex + 1, high, comp);
            }
        }

        private int Partition(T[] array, int low, int high, Comparare comp)
        {
            T pivot = array[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (comp(array[j], pivot) < 0)
                {
                    i++;
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }
            (array[high], array[i + 1]) = (array[i + 1], array[high]);
            return i + 1;
        }
    }
}

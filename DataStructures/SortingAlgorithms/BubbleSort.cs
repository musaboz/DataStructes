using System;
using System.Collections.Generic;
using DataStructures.Shared;

namespace DataStructures.SortingAlgorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// Time Complexity: O(n^2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Sort<T>(T[] array)
            where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    // Dizinin sonu her iterasyondan sonra bir geriye gelecek şekilde hareket eder. Yani ilk iterasyonda en sağda en büyük değer olmuş olur.
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Sorting.Swap<T>(array, j, j + 1);
                    }
                }
            }
        }
        public static void Sort<T>(T[] array, SortDirection sortDirection = SortDirection.Ascending)
            where T : IComparable
        {
            var comparer = new CustomComparer<T>(sortDirection, Comparer<T>.Default);
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    // Dizinin sonu her iterasyondan sonra bir geriye gelecek şekilde hareket eder. Yani ilk iterasyonda en sağda en büyük değer olmuş olur.
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        Sorting.Swap<T>(array, j, j + 1);
                    }
                }
            }
        }
    }
}

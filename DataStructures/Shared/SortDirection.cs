using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Shared
{
    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }

    public class CustomComparer<T> : IComparer<T>
        where T:IComparable
    {
        private readonly bool isMax;
        private readonly IComparer<T> comparer;
        public CustomComparer(SortDirection sortDirection, IComparer<T> comparer)
        {
            this.isMax = sortDirection == SortDirection.Descending;
            this.comparer = comparer;
        }
        public int Compare(T x, T y)
        {
            return !isMax ? CompareFunc(x, y) : CompareFunc(y, x);
        }

        private int CompareFunc(T x, T y) => comparer.Compare(x, y);
    }
}

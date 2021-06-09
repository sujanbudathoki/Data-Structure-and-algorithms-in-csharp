using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Problems
{
  public  class DistinctIntegerBest
    {
        public int CountDistinct(int[] a)
        {
            HashSet<int> store = new HashSet<int>();

            for(int i=0;i<a.Length;i++)
            {
                store.Add(a[i]);
            }
            return store.Count;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Problems.RoundTo1
{
  public   class RecursiveWrost
    {
        /* This is a problem where we need to calculate minimum steps for a number to 1.
         * ie through 3 ways :-
         * by subracting 1 -> n-1;
         * by diving with 2 if possible ie. =>n%2
         * by dividing with 3 if possible ie => n%3
          */
        public int MinimumSteps(int n)
        {
            if (n == 1)
                return 0;
            //using rescursion
            int result = MinimumSteps(n - 1);
            if (n % 2 == 0)
            {
                result = MinimumSteps(n % 2);

            }
            if (n % 3 == 0)
            {
                result = MinimumSteps(n % 3);

            }
            return result + 1;
        }

    }
}

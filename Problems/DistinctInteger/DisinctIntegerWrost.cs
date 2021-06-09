using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Problems
{
  public  class DisinctIntegerWrost
    {
        int count = 0;
        public int GetDistinct(int[] a)
        {
          
            for(int i=0;i<a.Length;i++)
            {
                int check = 0;
                count = (i == 0) ? count+1 : count ;
                if (i > 0)
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (a[i] == a[j])
                        {
                            check++;
                        }


                    }

                    count = check == 0 ? count+1 : count ;
                }
               
            
     
            }
            return count;
           
        }
    }
}

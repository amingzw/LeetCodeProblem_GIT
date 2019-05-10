/**
* 类 名 称  :_977_Squares_of_a_Sorted_Array
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/5/5 14:22:49
* 修改时间  :2019/5/5 14:22:49
*
* Copyright  @ 2018. All Rights reserved
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Array
{
    public class _977_Squares_of_a_Sorted_Array
    {
        public static int[] SortedSquares(int[] A)
        {
            //version 1 time O(nlogN) Space N
            /*List<int> resList = new List<int>(A.Length);
            for (int i = 0; i < A.Length; ++i)
            {
                resList.Add(A[i] * A[i]) ;
            }
            resList.Sort();
            
            return resList.ToArray();
            */
            //version 2 O(n)
            int i = 0;
            int j = A.Length - 1;
            int[] res = new int[A.Length];
            int m = j;
            while (i<=j)
            {
                if (Math.Abs(A[i]) > Math.Abs(A[j]))
                {
                    res[m] = A[i]*A[i];
                    i++;
                }
                else
                {
                    res[m] = A[j]*A[j];
                    j--;
                }

                --m;
            }

            return res;
        }
    }
}

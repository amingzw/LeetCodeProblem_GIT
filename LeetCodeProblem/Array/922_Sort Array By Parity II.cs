/**
* 类 名 称  :_922_Sort_Array_By_Parity_II
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/5/6 9:02:59
* 修改时间  :2019/5/6 9:02:59
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
    public class _922_Sort_Array_By_Parity_II
    {
        public static int[] SortArrayByParityII(int[] A)
        {
            //solution 1 O(N) space O(N)
            /*int i = 0,j=1;
            int[] res = new int[A.Length];
            for (int k = 0; k < A.Length; k++)
            {
                if (A[k]%2 == 0)
                {
                    res[i] = A[k];
                    i += 2;
                }
                else
                {
                    res[j] = A[k];
                    j += 2;
                }
            }

            return res;
            */

            //solution 2 time:O(N) space O(1)
            int j = 1;
            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i]%2 == 1)
                {
                    while (A[j]%2 == 1)
                    {
                        j++;
                    }
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            return A;

        }
    }
}

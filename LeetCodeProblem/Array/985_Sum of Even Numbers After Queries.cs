/**
* 类 名 称  :_985_Sum_of_Even_Numbers_After_Queries
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/5/10 15:23:39
* 修改时间  :2019/5/10 15:23:39
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
    public class _985_Sum_of_Even_Numbers_After_Queries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int[] res = new int[queries.Length];
            int sum  = A.Where(x => x % 2 == 0).Sum(); ;

            for (int i = 0; i < queries.Length; i++)
            {
                int val = queries[i][0];
                int index = queries[i][1];
                
                if (A[index]%2 == 0)
                {
                    sum -= A[index];
                }
                A[index] += val;
                if (A[index] % 2 == 0)
                {
                    sum += A[index];
                }
                
                res[i] = sum;

            }

            return res;
        }
    }
}

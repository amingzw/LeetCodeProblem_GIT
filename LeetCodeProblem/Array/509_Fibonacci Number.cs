/**
* 类 名 称  :_509_Fibonacci_Number
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/5/6 9:36:29
* 修改时间  :2019/5/6 9:36:29
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
    public class _509_Fibonacci_Number
    {
        private static int[] Stored = new int[31];
        public static int Fib(int N)
        {
            
            if (N <= 1)
            {
                return N;
            }

            if (Stored[N] == 0)
            {
                Stored[N] = Fib(N - 1) + Fib(N - 2);
            }
            return Stored[N];

        }
    }
}

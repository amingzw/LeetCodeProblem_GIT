/**
* 类 名 称  :_15_3Sum
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/4/26 11:11:23
* 修改时间  :2019/4/26 11:11:23
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
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<int> numList = nums.ToList();
            IList<IList<int>> resList = new List<IList<int>>();
            numList.Sort();
            for (int i = 0; i < numList.Count - 2; ++i)
            {
                if (numList[i] > 0) break;
                if (i > 0 && numList[i] == numList[i - 1])
                    continue;
                int left = i + 1;
                int right = numList.Count - 1;

                while (left < right)
                {
                    int sum = numList[i] + numList[left] + numList[right];
                    if (sum == 0)
                    {
                        List<int> val = new List<int> { numList[i], numList[left], numList[right] };
                        resList.Add(val);
                        while (left < right && numList[left] == numList[left + 1])
                        {
                            left++;
                        }
                        while (left < right && numList[right] == numList[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else
                        left++;
                }

            }

            return resList;
        }
    }
}

/**
* 类 名 称  :_11_Container_With_Most_Water
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/4/22 15:38:12
* 修改时间  :2019/4/22 15:38:12
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
    /// <summary>
    /// 首先计算宽度最大  然后往中间走 宽度变小取高度最大的
    /// </summary>
    public class _11_Container_With_Most_Water
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int i = 0;
            int j = height.Length - 1;
            while (i < j)
            {
                maxArea = Math.Max(Math.Min(height[i], height[j]) * (j - i),maxArea);
                if(height[i]<=height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            
            return maxArea;
        }
        
    }
}

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
            IList<int> pInt = nums.Where((c) => c > 0).ToList();
            IList<int> zInt = nums.Where((c) => c == 0).ToList();
            IList<int> nInt = nums.Where((c) => c < 0).ToList();

            

            return null;
        }

        public static int test()
        {
            string[] strList = new string[] { "nesa.id", "rfca.name", "nesa.tt", "trea.tt", "rfca.yy" };
            var tt = strList.GroupBy(x => x.Split('.')[0], y => y.Split('.')[1])
                .ToDictionary(group => group.Key, group =>group.ToList());
            foreach (var t in tt.Keys)
            {
                string key = t;
                foreach (var s in tt[t])
                {
                    string d = s;
                }
            }
            return 0;
        }
    }
}

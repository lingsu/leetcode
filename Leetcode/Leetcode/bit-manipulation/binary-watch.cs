//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace Leetcode.bit_manipulation
//{
//    /// <summary>
//    /// 二进制手表
//    /// </summary>
//    public class binary_watch
//    {
//        private int[] nums = new int[] { 1, 2, 4, 8, 1, 2, 4, 8, 16, 32 };
//        private int[] visited;
//        private List<string> resultAll;
//        public void 二进制手表()
//        {

//        }
//        public IList<string> ReadBinaryWatch(int num)
//        {
//            resultAll = new List<string>();
//            //Enumerable.Range(0,5)

//            visited = new int[nums.Length];
//            //Dfs(num, new List<string>(), 0);
//            Dfs(num, 0, 0);
//            return resultAll;
//        }
//        private void Dfs(int num, int step, int start)
//        {
//            if (step == num)
//            {
//                resultAll.Add(HandleDate(visited))
//            }
//        }
//        private string HandleDate(int[] visited)
//        {
//            var sum_h = 0;
//            var sum_m = 0;
//            for (int i = 0; i < visited.Length; i++)
//            {
//                if (visited[i] == 0)
//                {
//                    continue;
//                }
//                if (i < 4)
//                {
//                    sum_h += nums[i];
//                }
//                else
//                {

//                }
//            }
//        }

//    }
//}

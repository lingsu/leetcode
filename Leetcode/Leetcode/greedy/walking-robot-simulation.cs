using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;

namespace Leetcode.greedy
{
    /// <summary>
    /// 模拟行走机器人
    /// </summary>
    public class walking_robot_simulation
    {
        [Fact]
        public void 模拟行走机器人()
        {
            RobotSim(new int[] { 4, -1, 3 }, new int[0][]).ShouldBe(25);
            RobotSim(new int[] { 4, -1, 4, -2, 4 }, new int[][] { new int[] { 2, 4 } }).ShouldBe(65);
        }
        //机器人在一个无限大小的网格上行走，从点(0, 0) 处开始出发，面向北方。该机器人可以接收以下三种类型的命令：

        //-2：向左转 90 度
        //-1：向右转 90 度
        //1 <= x <= 9：向前移动 x 个单位长度
        //在网格上有一些格子被视为障碍物。

        //第 i 个障碍物位于网格点(obstacles[i][0], obstacles[i][1])

        //机器人无法走到障碍物上，它将会停留在障碍物的前一个网格方块上，但仍然可以继续该路线的其余部分。

        //返回从原点到机器人的最大欧式距离的平方。

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/walking-robot-simulation
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            var dx = new int[] { 0, 1, 0, -1 };
            var dy = new int[] { 1, 0, -1, 0 };
            int x = 0, y = 0, di = 0;

            var obstaclePoints = new HashSet<long>();
            foreach (var obstacle in obstacles)
            {
                var ox = (long)obstacle[0] + 30000;
                var oy = (long)obstacle[1] + 30000;
                obstaclePoints.Add((ox << 16) + oy);
            }

            var ans = 0;
            foreach (var command in commands)
            {
                if (command == -2) //left
                {
                    di = (di + 3) % 4;
                }
                else if (command == -1) //right
                {
                    di = (di + 1) % 4;
                }
                else
                {
                    for (int i = 0; i < command; i++)
                    {
                        var nx = x + dx[di];
                        var ny = y + dy[di];
                        var point = ((long)(nx + 30000) << 16) + ((long)ny + 30000);
                        if (!obstaclePoints.Contains(point))
                        {
                            x = nx;
                            y = ny;
                            ans = Math.Max(ans, x * x + y * y);
                        }
                    }
                   
                }
            }

            return ans;
        }
    }
}

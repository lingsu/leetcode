using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using System.Linq;
using System.Threading;

namespace Leetcode.lock_test
{
    /// <summary>
    /// 本文主要是试验在顺序进入等待 SemaphoreSlim 的任务是否会按照顺序经过锁执行
    /// </summary>
    public class SemaphoreSlim_Test
    {
        private static readonly AutoResetEvent _autoResetEvent = new AutoResetEvent(true);

        //[Fact]
        public void 按照顺序经过锁执行()
        {
            var semaphoreSlim = new SemaphoreSlim(10, 20);

            for (int i = 0; i < 1000; i++)
            {
                var n = i;
                _autoResetEvent.WaitOne();
                new Thread(() => { GeregelkunoNeawhikarcee(semaphoreSlim, n); }).Start();
            }
        }
        private static void GeregelkunoNeawhikarcee(SemaphoreSlim semaphoreSlim, int n)
        {
            Console.WriteLine($"{n} 进入");
            _autoResetEvent.Set();

            semaphoreSlim.Wait();
            Console.WriteLine(n);

            Thread.Sleep(TimeSpan.FromSeconds(1));
            semaphoreSlim.Release();
        }
    }
}

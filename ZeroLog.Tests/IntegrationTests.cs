﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using ZeroLog.Appenders;

namespace ZeroLog.Tests
{
    [TestFixture]
    [Ignore("Manual")]
    public class IntegrationTests
    {
        private PerformanceAppender _performanceAppender;
        private const int _nbThreads = 4;
        private const int _count = 5 * 1000;

        [SetUp]
        public void SetUp()
        {
            _performanceAppender = new PerformanceAppender(_count * _nbThreads);
            LogManager.Initialize(new[] { _performanceAppender, }, 1 << 16);
            Thread.Sleep(1);
        }

        [TearDown]
        public void Teardown()
        {
            LogManager.Shutdown();
        }

        [Test]
        public void should_test_console()
        {
            LogManager.GetLogger(typeof(IntegrationTests)).Info().Append("Hello").Log();
        }

        [Test]
        public void should_test_append()
        {

            Console.WriteLine("Starting test");
            var sw = Stopwatch.StartNew();

            Parallel.For(0, _nbThreads, threadId =>
            {
                var logger = LogManager.GetLogger(typeof(IntegrationTests).Name + threadId.ToString());
                for (var i = 0; i < _count; i++)
                {
                    logger.InfoFormat("{0}", Stopwatch.GetTimestamp());
                    Thread.Sleep(5);
                }
                //                logger.InfoFormat("{0}", (byte)1, (char)1, (short)2, (float)3, 2.0, "", true, TimeSpan.Zero);
            });

            LogManager.Shutdown();
            var throughput = _count / sw.Elapsed.TotalSeconds;

            Console.WriteLine($"Finished test, throughput is: {throughput:N0}");

            _performanceAppender.PrintTimeTaken();
            Console.WriteLine("Printed total time taken csv");
        }

        [Test]
        public void should_not_allocate()
        {
            const int count = 1000000;

            GC.Collect(2, GCCollectionMode.Forced, true);
            var gcCount = GC.CollectionCount(0);

            var timer = Stopwatch.StartNew();

            var logger = LogManager.GetLogger(typeof(IntegrationTests));
            for (int k = 0; k < count; k++)
            {
                Thread.Sleep(1);
                logger.Info().Append("Hello").Log();
            }

            LogManager.Shutdown();
            timer.Stop();
            Console.WriteLine("BCL  : {0} us/log", timer.ElapsedMilliseconds * 1000.0 / count);
            Console.WriteLine("GCs  : {0}", GC.CollectionCount(0) - gcCount);
        }
    }
}

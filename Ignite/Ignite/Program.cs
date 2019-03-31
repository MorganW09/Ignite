using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Ignite.Benchmarking;
using System;

namespace Ignite
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LinkedListBenchmarking>();
            Console.ReadKey();
        }
    }
}

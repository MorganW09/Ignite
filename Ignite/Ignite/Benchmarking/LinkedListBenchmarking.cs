using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using IgniteDS = Ignite.DataStructures;

namespace Ignite.Benchmarking
{
    [MemoryDiagnoser]
    [CsvExporter]
    public class LinkedListBenchmarking
    {

        [Benchmark]
        public void BenchmarkDotNetLinkedList()
        {
            var dotnetLinkedList = new LinkedList<int>();
            for(int i = 0; i < 1_000_000; i++)
            {
                dotnetLinkedList.AddLast(i);
            }

            for(int i = 0; i < 1_000_000; i++)
            {
                dotnetLinkedList.Remove(i);
            }
        }

        [Benchmark]
        public void BenchmarkIgniteLinkedList()
        {
            var igniteLinkedList = new IgniteDS.LinkedList();
            for (int i = 0; i < 1_000_000; i++)
            {
                igniteLinkedList.AddLast(i);
            }

            for (int i = 0; i < 1_000_000; i++)
            {
                igniteLinkedList.Remove(i);
            }
        }
    }
}

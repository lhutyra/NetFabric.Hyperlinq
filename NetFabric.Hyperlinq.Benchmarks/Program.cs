﻿using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NetFabric.Hyperlinq.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                    typeof(GenerationOperationsBenchmarks),
                    typeof(CountBenchmarks),
                    typeof(SelectBenchmarks),
                    typeof(CachingBenchmarks),
                });
            switcher.Run(args);        
        }
    }
}

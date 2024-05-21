using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models
{
    public class BenchmarkViewModel
    {
        public IEnumerable<CpuBenchmark> CpuBenchmarks { get; set; }
        public IEnumerable<GpuBenchmark> GpuBenchmarks { get; set; }
        public IEnumerable<RamBenchmark> RamBenchmarks { get; set; }
    }
}
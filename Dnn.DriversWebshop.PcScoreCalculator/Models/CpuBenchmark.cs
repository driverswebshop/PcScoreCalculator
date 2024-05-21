using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models
{
    public class CpuBenchmark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public float Percentage { get; set; }
    }
}
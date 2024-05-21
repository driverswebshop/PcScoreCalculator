using DotNetNuke.Data;
using DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Repositories
{
    public class GpuBenchmarkRepository : IBenchmarkRepository<GpuBenchmark>
    {
        public IEnumerable<GpuBenchmark> GetAll()
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<GpuBenchmark>().Get().ToList();
            }
        }

        public GpuBenchmark GetById(int id)
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<GpuBenchmark>().GetById(id);
            }
        }
    }
}
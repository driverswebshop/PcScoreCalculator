using DotNetNuke.Data;
using DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Repositories
{
    public class CpuBenchmarkRepository : IBenchmarkRepository<CpuBenchmark>
    {
        public IEnumerable<CpuBenchmark> GetAll()
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<CpuBenchmark>().Get().ToList();
            }
        }

        public CpuBenchmark GetById(int id)
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<CpuBenchmark>().GetById(id);
            }
        }
    }
}
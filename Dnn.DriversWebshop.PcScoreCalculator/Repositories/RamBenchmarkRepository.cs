using DotNetNuke.Data;
using DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Repositories
{
    public class RamBenchmarkRepository : IBenchmarkRepository<RamBenchmark>
    {
        public IEnumerable<RamBenchmark> GetAll()
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<RamBenchmark>().Get().ToList();
            }
        }

        public RamBenchmark GetById(int id)
        {
            using (var context = DataContext.Instance())
            {
                return context.GetRepository<RamBenchmark>().GetById(id);
            }
        }
    }
}
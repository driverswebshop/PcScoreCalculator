using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Repositories
{
    public interface IBenchmarkRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
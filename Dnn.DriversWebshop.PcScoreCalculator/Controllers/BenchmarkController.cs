using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Models;
using DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Repositories;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    [DnnHandleError]
    public class BenchmarkController : Controller
    {
        private readonly IBenchmarkRepository<CpuBenchmark> _cpuRepository;
        private readonly IBenchmarkRepository<GpuBenchmark> _gpuRepository;
        private readonly IBenchmarkRepository<RamBenchmark> _ramRepository;

        public BenchmarkController()
        {
            _cpuRepository = new CpuBenchmarkRepository();
            _gpuRepository = new GpuBenchmarkRepository();
            _ramRepository = new RamBenchmarkRepository();
        }

        public ActionResult Index()
        {
            var model = new BenchmarkViewModel
            {
                CpuBenchmarks = _cpuRepository.GetAll(),
                GpuBenchmarks = _gpuRepository.GetAll(),
                RamBenchmarks = _ramRepository.GetAll()
            };

            return View(model);
        }

        public ActionResult CalculateScore(int cpuId, int gpuId, int ramId)
        {
            var cpu = _cpuRepository.GetById(cpuId);
            var gpu = _gpuRepository.GetById(gpuId);
            var ram = _ramRepository.GetById(ramId);

            if (cpu == null || gpu == null || ram == null)
            {
                return HttpNotFound();
            }

            var score = (cpu.Percentage + gpu.Percentage + ram.Percentage) / 3;
            ViewBag.Score = score;

            return View();
        }
    }
}
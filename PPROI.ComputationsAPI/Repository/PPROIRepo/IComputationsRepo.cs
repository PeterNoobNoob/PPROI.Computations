using PPROI.ComputationsAPI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPROI.ComputationsAPI.Repository.PPROIRepo
{
    public interface IComputationsRepo
    {
        IEnumerable<Result> GetResults();
        IEnumerable<Result> GetResultById(int id);

    }
}

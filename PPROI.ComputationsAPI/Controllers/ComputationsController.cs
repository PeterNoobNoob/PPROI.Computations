using Microsoft.AspNetCore.Mvc;
using PPROI.ComputationsAPI.Repository.Models;
using PPROI.ComputationsAPI.Repository.PPROIRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPROI.ComputationsAPI.Controllers
{
    [Route("api/1.0/computations")]
    public class ComputationsController : ControllerBase
    {
        private readonly IComputationsRepo _computationsRepo = new ComputationsRepo();

        public ComputationsController(IComputationsRepo computationsRepo)
        {
            _computationsRepo = computationsRepo;
        }

        //test comment
        [HttpGet]
        //[Route("api/1.0/computations/sample")]
        public ActionResult <IEnumerable<Result>> Index()
        {
            var comps = _computationsRepo.GetResults();

            return Ok(comps);
        }

        [HttpPost]
        //[Route("api/1.0/computations/sample")]
        public ActionResult<IEnumerable<Result>> GetComputationsById(int id)
        {
            var comps = _computationsRepo.GetResultById(id);

            return Ok(comps);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PPROI.ComputationsAPI.Repository.Models;
using PPROI.ComputationsAPI.Repository.PPROIRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPROI.ComputationsAPI.Controllers
{
    public class ComputationsController : ControllerBase
    {
        private readonly ComputationsRepo _computationsRepo = new ComputationsRepo();

        //test comment
        [HttpGet]
        [Route("api/1.0/computations/sample")]
        public ActionResult <IEnumerable<Result>> GetComputations()
        {
            var comps = _computationsRepo.GetResults();

            return Ok(comps);
        }

        [HttpPost]
        [Route("api/1.0/computations/sample")]
        public ActionResult<IEnumerable<Result>> GetComputationsById(int id)
        {
            var comps = _computationsRepo.GetResultById(id);

            return Ok(comps);
        }
    }
}

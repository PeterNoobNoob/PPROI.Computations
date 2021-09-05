using PPROI.ComputationsAPI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPROI.ComputationsAPI.Repository.PPROIRepo
{
    public class ComputationsRepo : IComputationsRepo
    {
        public IEnumerable<Result> GetResults()
        {
            var res = new List<Result>
            {
                new Result { EntityId = 1, RoomVolume = 10}
            };

            return res;
        }

        public IEnumerable<Result> GetResultById(int id)
        {
            var res = new List<Result>
            {
                new Result { EntityId = 1, RoomVolume = 10}
            };

            return res;
        }
    }
}

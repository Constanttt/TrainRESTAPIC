using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevisesController
    {
        [HttpGet]
        public Dictionary<string, Double> Get()
        {
            Train train = new Train();

            return train.getDevises();
        }
    }
}

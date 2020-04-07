using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainController : ControllerBase
    {
        const Double PRIXKILOMETRE = 0.25;
        [HttpGet]
        public Train Get(String monnaie = "EUR", Double distance = 0)
        {
            Train train = new Train();
            double prixT = distance * PRIXKILOMETRE;

            Dictionary<string, Double> devises = train.getDevises();

            if (devises.ContainsKey(monnaie.ToUpper()))
            {
                train.prix = prixT * devises[monnaie.ToUpper()];
            }

            return train;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI.Controllers
{
    [ApiController]
    [Route("[controller]/monnaie/{monnaie}/distance/{distance}")]
    public class TrainController : ControllerBase
    {
        const Double PRIXKILOMETRE = 0.25;
        [HttpGet]
        public Train Get(String monnaie, Double distance)
        {
            Train train = new Train();
            double prixT = distance * PRIXKILOMETRE;
            switch (monnaie.ToUpper())
            {
                case "EUR":
                    train.Prix = prixT * 1;
                    break;
                case "GBP":
                    train.Prix = prixT * 0.8827;
                    break;
                case "AUD":
                    train.Prix = prixT * 1.7592;
                    break;
                case "USD":
                    train.Prix = prixT * 1.0916;
                    break;
                default:
                    train.Prix = prixT * 1;
                    break;
            }
            return train;
        }
    }
}

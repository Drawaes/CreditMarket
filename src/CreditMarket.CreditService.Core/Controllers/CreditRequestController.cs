using CreditMarket.CreditService.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditMarket.CreditService.Core.Controllers
{
    [Route("api/[controller]")]
    public class CreditRequestController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post([FromBody]CreditRequest request)
        {
            return Ok();
        }

        [HttpGet]
        public IEnumerable<CreditRequest> Get()
        {
            return new CreditRequest[]
            {
                new CreditRequest()
                {
                    LoanType = "Car",
                    LoanValue = 10000M,
                    PrimaryRequestor = new User()
                    {
                        CreditRating = 700,
                        FirstName = "Bob",
                        LastName = "Smith"
                    }
                },
                new CreditRequest()
                {
                    LoanType = "Home",
                    LoanValue = 250000M,
                    PrimaryRequestor = new User()
                    {
                        CreditRating = 999,
                        FirstName = "Sarah",
                        LastName = "Smith"
                    }
                }
            };
        }
    }
}

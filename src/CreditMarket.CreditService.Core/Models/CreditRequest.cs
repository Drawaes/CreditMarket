using System;
using System.Collections.Generic;
using System.Text;

namespace CreditMarket.CreditService.Core.Models
{
    public class CreditRequest
    {
        public string LoanType { get; set; }
        public decimal LoanValue { get; set; }
        public User PrimaryRequestor { get; set; }
    }
}

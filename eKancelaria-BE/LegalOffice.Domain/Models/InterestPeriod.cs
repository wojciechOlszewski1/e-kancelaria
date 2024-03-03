using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class InterestPeriod
    {
        public int Id { get; set; }
        public string Description { get; set; } 

        public string DateFrom { get; set; } 

        public string DateTo { get; set; }

        public decimal Amount { get; set; }

        public bool AmountSpecified { get; set; } 

        public sbyte IsStatutory { get; set; } 

        public decimal Rate { get; set; }

        public bool RateSpecified { get; set; } 

        public sbyte Period { get; set; }

        public bool PeriodSpecified { get; set; } 

        public sbyte FromSubmission { get; set; }

        public bool FromSubmissionSpecified { get; set; }

        public sbyte ToPayment { get; set; } 

        public bool ToPaymentSpecified { get; set; } 
    }
}

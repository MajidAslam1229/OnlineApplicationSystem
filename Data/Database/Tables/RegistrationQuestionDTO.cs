using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Data.Database.Tables
{
    public class RegistrationQuestionDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public int? PositionAppliedFor { get; set; }
        public DateTime? AvailableOrientationDate { get; set; }
        public int? RefferralSource { get; set; }

        public string RefferalType { get; set; }
        public bool? WorkedforthiscompanyBefore { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string PositionHeld { get; set; }
        public bool? AuthorizeForContact { get; set; }
        public bool? FMCSADrugandAlcoholClearinghouseregistered { get; set; }

       
    }
}

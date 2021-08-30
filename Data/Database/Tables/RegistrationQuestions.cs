using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class RegistrationQuestions
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public int? PositionAppliedFor { get; set; }
        public DateTime? AvailableOrientationDate { get; set; }
        public int? RefferralSource { get; set; }
        public bool? WorkedforthiscompanyBefore { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string PositionHeld { get; set; }
        public bool? AuthorizeForContact { get; set; }
        public bool? FMCSADrugandAlcoholClearinghouseregistered { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }
        public string RefferalType { get; set; }

        public virtual DriverType PositionAppliedForNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class DriverLicense
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public int? State_Province { get; set; }
        public string LicenseNumber { get; set; }
        public int? LicenseType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? CurrentOperatinglicense { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual RegistrationPersonalInformation Registration { get; set; }
        public virtual States State_ProvinceNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class RegistrationPersonalInformation
    {
        public RegistrationPersonalInformation()
        {
            AdditionalInformation = new HashSet<AdditionalInformation>();
            DriverLicense = new HashSet<DriverLicense>();
            Traffic_Accidents = new HashSet<Traffic_Accidents>();
            Traffic_Convictions = new HashSet<Traffic_Convictions>();
            WorkHistory = new HashSet<WorkHistory>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public int? Country { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual ICollection<AdditionalInformation> AdditionalInformation { get; set; }
        public virtual ICollection<DriverLicense> DriverLicense { get; set; }
        public virtual ICollection<Traffic_Accidents> Traffic_Accidents { get; set; }
        public virtual ICollection<Traffic_Convictions> Traffic_Convictions { get; set; }
        public virtual ICollection<WorkHistory> WorkHistory { get; set; }
    }
}

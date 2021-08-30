using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class PreQualification
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Country { get; set; }
        public int? State { get; set; }
        public string Zip { get; set; }
        public int? DriverType { get; set; }
        public int? SSN { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public bool? _21YearsAge { get; set; }
        public bool? ViolationsLast3years { get; set; }
        public bool? AccidentsLast5years { get; set; }
        public bool? Validdriverslicense { get; set; }
        public bool? OneYearOTRExperience { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual DriverType DriverTypeNavigation { get; set; }
        public virtual States StateNavigation { get; set; }
    }
}

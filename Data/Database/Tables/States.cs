using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class States
    {
        public States()
        {
            AdditionalInformation = new HashSet<AdditionalInformation>();
            DriverLicense = new HashSet<DriverLicense>();
            PreQualification = new HashSet<PreQualification>();
            RegistrationAddress = new HashSet<RegistrationAddress>();
            Traffic_Accidents = new HashSet<Traffic_Accidents>();
            Traffic_Convictions = new HashSet<Traffic_Convictions>();
            WorkHistory = new HashSet<WorkHistory>();
            WorkHistoryReferences = new HashSet<WorkHistoryReferences>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<AdditionalInformation> AdditionalInformation { get; set; }
        public virtual ICollection<DriverLicense> DriverLicense { get; set; }
        public virtual ICollection<PreQualification> PreQualification { get; set; }
        public virtual ICollection<RegistrationAddress> RegistrationAddress { get; set; }
        public virtual ICollection<Traffic_Accidents> Traffic_Accidents { get; set; }
        public virtual ICollection<Traffic_Convictions> Traffic_Convictions { get; set; }
        public virtual ICollection<WorkHistory> WorkHistory { get; set; }
        public virtual ICollection<WorkHistoryReferences> WorkHistoryReferences { get; set; }
    }
}

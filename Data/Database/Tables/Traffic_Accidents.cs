using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class Traffic_Accidents
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public DateTime? AccidentDate { get; set; }
        public int? AccidentType { get; set; }
        public int? Typeof_Vehicle { get; set; }
        public int? TrailerType { get; set; }
        public bool? Was_this_accident_preventable_ { get; set; }
        public string City { get; set; }
        public int? State_Province { get; set; }
        public bool? Property_Damage_ { get; set; }
        public string Accident_Details { get; set; }
        public bool? Fatalities { get; set; }
        public bool? Injuries { get; set; }
        public bool? Hazardous_Spills { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual RegistrationPersonalInformation Registration { get; set; }
        public virtual States State_ProvinceNavigation { get; set; }
    }
}

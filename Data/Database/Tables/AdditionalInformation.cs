using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class AdditionalInformation
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string SchoolName { get; set; }
        public DateTime? LastDateAttended { get; set; }
        public int? YearsCompleted { get; set; }
        public string City { get; set; }
        public int? State_Province { get; set; }
        public string Phone { get; set; }
        public bool? Attendeddrivingschool { get; set; }
        public bool? Can_you_perform_the_essential_functions_of_the_job_of_a_projessional_diver { get; set; }
        public bool? Do_you_have_a_TWIC { get; set; }
        public bool? Do_you_have_passport_or_ehanced_driver_s_license { get; set; }
        public bool? Requiredgreencardorvisa { get; set; }
        public bool? Legalnameotherthantheoneonapplication { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual RegistrationPersonalInformation Registration { get; set; }
        public virtual States State_ProvinceNavigation { get; set; }
    }
}

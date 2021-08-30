using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class AdditionalInformationDTO
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
    }
}

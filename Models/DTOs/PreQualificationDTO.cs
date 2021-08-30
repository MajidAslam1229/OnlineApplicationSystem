using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class PreQualificationDTO
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



    }
}

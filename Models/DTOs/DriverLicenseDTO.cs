using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class DriverLicenseDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public int? State_Province { get; set; }
        public string LicenseNumber { get; set; }
        public int? LicenseType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? CurrentOperatinglicense { get; set; }
    }
}

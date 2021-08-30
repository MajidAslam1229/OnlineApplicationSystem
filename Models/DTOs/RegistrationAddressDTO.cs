using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class RegistrationAddressDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OtherPhone { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalYears { get; set; }
        public int? TotalMonth { get; set; }
        public string Type { get; set; }

    }
}

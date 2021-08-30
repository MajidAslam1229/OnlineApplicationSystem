using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class TrafficConvictionsDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public DateTime? ConvictionDate { get; set; }
        public string Charges { get; set; }
        public string Penalty { get; set; }
        public string City { get; set; }
        public int? State_Province { get; set; }
        public int? Type_of_Vehicle { get; set; }
        public string Explaination { get; set; }
        public string Cited_Speed { get; set; }
        public string Posted_Speed { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class TrafficAccidentsDTO
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class WorkHistoryDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public string EmployerName { get; set; }
        public bool? Isthisyourcurrentemployer { get; set; }
        public int? PositionHeld { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string EquipmentDriven { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool? Maywecontactthisemployer { get; set; }
        public string ReasonForLeaving { get; set; }
        public string GeographicAreasofOperation { get; set; }
        public int? NumberofStates_ProvincesDriven { get; set; }
        public bool? operate_a_motor_vehicle_in_interstate_commerce_used_to_transport_passengers_or_property_and_the_vehicle { get; set; }
        public bool? Was_this_job_position_designated_as_a_safety_sensitive_function_in_any_DOT_regulated_mode { get; set; }
        public bool? operate_a_motor_vehicle_that_required_a_commercial_driver_s_license { get; set; }
        public string Notes { get; set; }
        public bool? Authorizesignatureforworkhistoryandworkgap { get; set; }
        public bool? IncludeemployerforDrugandAlcoholtest { get; set; }

        public List<WorkHistoryReferencesDTO> workHistoryReferencesDTOs { get; set; }
    }
}

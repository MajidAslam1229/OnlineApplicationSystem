using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class WorkHistory
    {
        public WorkHistory()
        {
            WorkHistoryReferences = new HashSet<WorkHistoryReferences>();
        }

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
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual RegistrationPersonalInformation Registration { get; set; }
        public virtual States StateNavigation { get; set; }
        public virtual ICollection<WorkHistoryReferences> WorkHistoryReferences { get; set; }
    }
}

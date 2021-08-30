using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class HaulExperience
    {
        public int Id { get; set; }
        public int? AdditionalInformationId { get; set; }
        public string EquipmentType { get; set; }
        public string DrivenForm { get; set; }
        public string Comments_Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string RecordStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class BackgroundQuestionDetails
    {
        public int Id { get; set; }
        public int? BackgroudQuestionMasterId { get; set; }
        public DateTime? Date { get; set; }
        public string Explain { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual BackgroundQuestionsMaster BackgroudQuestionMaster { get; set; }
    }
}

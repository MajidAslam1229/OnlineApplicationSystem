using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class BackgroundQuestionsMaster
    {
        public BackgroundQuestionsMaster()
        {
            BackgroundQuestionDetails = new HashSet<BackgroundQuestionDetails>();
        }

        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public string Name { get; set; }
        public bool? Answer { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<BackgroundQuestionDetails> BackgroundQuestionDetails { get; set; }
    }
}

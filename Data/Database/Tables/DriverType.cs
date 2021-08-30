﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineJobApplication.Data.Database.Tables
{
    public partial class DriverType
    {
        public DriverType()
        {
            PreQualification = new HashSet<PreQualification>();
            RegistrationQuestions = new HashSet<RegistrationQuestions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? RecordStatus { get; set; }

        public virtual ICollection<PreQualification> PreQualification { get; set; }
        public virtual ICollection<RegistrationQuestions> RegistrationQuestions { get; set; }
    }
}
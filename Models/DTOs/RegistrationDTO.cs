using OnlineJobApplication.Data.Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class RegistrationDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public int? Country { get; set; }
        public List<RegistrationAddressDTO> Address { get; set; }
        public RegistrationQuestionDTO registrationQuestionDTO { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class BackgroundInformationDTO
    {
        public int Id { get; set; }
        public int? RegistrationId { get; set; }
        public string Name { get; set; }
        public bool? Answer { get; set; }

        public List<BackgroundQuestiondDetailsDTO> backgroundQuestiondDetailsDTOs { get; set; }
    }
}

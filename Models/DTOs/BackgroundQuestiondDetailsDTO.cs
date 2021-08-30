using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Models.DTOs
{
    public class BackgroundQuestiondDetailsDTO
    {
        public int Id { get; set; }
        public int? BackgroudQuestionMasterId { get; set; }
        public DateTime? Date { get; set; }
        public string Explain { get; set; }
    }
}

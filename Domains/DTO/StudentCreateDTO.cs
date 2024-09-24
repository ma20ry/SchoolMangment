using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.DTO
{
    public class StudentCreateDTO
    {
        public string name { get; set; }
        public DateOnly birthday { get; set; }
        public double average { get; set; }
        
        public string Gender { get; set; }
        public string? img { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? TeacherId { get; set; }

    }
}

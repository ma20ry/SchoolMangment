using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.DTO
{
    public class ClassUpdateDTO
    {
        public int Id { get; set; }
        public string NameClass { get; set; }
        public string NumberofStudents { get; set; }
        public string NumberofSubjects { get; set; }
        public DateOnly startdate { get; set; }
        public DateOnly enddate { get; set; }
    }
}

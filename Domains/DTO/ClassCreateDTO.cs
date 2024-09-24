using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.DTO
{
    public class ClassCreateDTO
    {
        public string NameClass { get; set; }
        public int NumberofStudents { get; set; }
        public int NumberofSubjects { get; set; }
        public DateOnly startdate { get; set; }
        public DateOnly enddate { get; set; }

        public List<string>? Studentname{ get; set; }
    }
}

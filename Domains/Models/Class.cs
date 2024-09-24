using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class Class : BaseModel
    {
        public string NameClass { get; set; }
        public int NumberofStudents { get; set; }
        public int NumberofSubjects { get; set; }
        public DateOnly startdate { get; set; }
        public DateOnly enddate { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<TableSubject> Tables { get; set; }
        public ICollection<Teacher> Teachers { get; set; }


    }
}

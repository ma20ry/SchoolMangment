using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class Subject : BaseModel
    {
        public int? TeacherId { get; set; }
        public Teacher? Teacheres { get; set; }
        public ICollection<TableSubject> Tables { get; set; }
        public int? StudentId { get; set; }
        public Student? studentes { get; set; }
        public int? ClassId { get; set; }
        public Class? classes { get; set; }


    }
}

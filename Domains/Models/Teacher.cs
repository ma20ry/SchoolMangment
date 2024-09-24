using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class Teacher : BaseModel
    {
        public string name { get; set; }
        public DateOnly birthday { get; set; }
        public string no { get; set; } 
        public string imgurl { get; set; }
        public double salary { get; set; }
        public string Gender { get; set; }
        public ICollection<Subject>? subjects { get; set; }
        public ICollection<Class>? classes { get; set; }
        public ICollection<Student>? students { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class TableSubject : BaseModel
    {
       
        public string name {  get; set; }
        public DateTime Time { get; set; }
        public string className { get; set; }
        public int? SubjectId { get; set; }
        public Subject? Subjectes { get; set; }
        public int? ClassId { get; set; }
        public Class? classes { get; set; }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models
{
    public class Student : BaseModel
    {
      public string name {  get; set; }
      public DateOnly birthday { get; set; }
     public double average { get; set; }
     public string? img {  get; set; }
     public string Gender { get; set; }
        public int? ClassId { get; set; }
        public Class? classes { get; set; }
     public ICollection<Subject>? subjects { get; set; }
    public ICollection<Teacher>? teachers { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.DTO
{
    public class StudentUpdateDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateOnly birthday { get; set; }
        public double average { get; set; }

        public string Gender { get; set; }
       
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class Compensation
    {
        public Employee Employee { get; set; }
        public Float Salary { get; set; }
        public DateTime effectiveDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime Date1 { get; set; }
        public string TypeOfVisit { get; set; }
        public string Diagnosis { get; set; }
        public int VisitCount { get; set; }
        public int Month1 { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Adress { get; set; }
        public Int64 Phone { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }  //список посещений пациента!
        public Patient()
        {
            Visits = new List<Visit>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

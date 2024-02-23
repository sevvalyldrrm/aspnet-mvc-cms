using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class SurgeryDoctor: BaseEntity
    {
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int SurgeryId { get; set; }
        public Surgery Surgery { get; set; }
    }

}

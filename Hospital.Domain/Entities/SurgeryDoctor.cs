using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
    public class SurgeryDoctor : BaseEntitiy
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int SurgeryId { get; set; }
        public Surgery Surgery { get; set; }
    }

}

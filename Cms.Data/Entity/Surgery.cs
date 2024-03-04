using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class Surgery : BaseEntity
    {
        [ForeignKey(nameof(Patient.Id))]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }        

        [ForeignKey(nameof(Department.Id))]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<SurgeryDoctor> SurgeryDoctors { get; set; }

        public DateTime SurgeryDate { get; set; }


    }
}

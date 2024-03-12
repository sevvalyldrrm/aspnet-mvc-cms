using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
    public class Introduction : BaseEntitiy
	{
        //Doctor Single

        [ForeignKey(nameof(Doctor.Id))]
        public int DoctorId {  get; set; }
        public Doctor Doctor { get; set; }
        public string Description { get; set; }
        public string MySkills { get; set; }
        [NotMapped]
        public virtual ICollection<string> ExpertisesAreas { get; set; }
        public ICollection<Education> Educations { get; set; }
        public WorkingHour WorkingHour { get; set; } //Make appointment'teki doktora uygun çalışma saatleri


       
    }
}

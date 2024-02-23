using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class Introduction
    {
        //Doctor Single
        public int Id { get; set; }

        [ForeignKey(nameof(Doctor.Id))]
        public string DoctorId {  get; set; }
        public Doctor Doctor { get; set; }
        public string Description { get; set; }
        public string MySkills { get; set; }
        public ICollection<string> ExpertisesAreas { get; set; }
        public ICollection<Education> Educations { get; set; }

        
        public WorkingHour WorkingHour { get; set; } //Make appointment'teki doktora uygun çalışma saatleri


       
    }
}

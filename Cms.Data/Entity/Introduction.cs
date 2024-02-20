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
        public int Id { get; set; }

        [ForeignKey(nameof(Doctor.Id))]
        public string DoctorId {  get; set; }
        public string Description { get; set; }
        public string MySkills { get; set; }
        public ICollection<string> ExpertisesArea { get; set; }
        public ICollection<Education> Educations { get; set; }

        public string WorkingDays {  get; set; }//check-box
        public string WorkingHours {  get; set; }
      

        public Education Education { get; set; }
    }
}

using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class Education : BaseEntity
    {
        //Doctor's Education
        public string Year { get; set; }

        public string University { get; set; }

        public string Explanation { get; set; }

        [ForeignKey(nameof(Doctor.Id))]
        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }

    }
}

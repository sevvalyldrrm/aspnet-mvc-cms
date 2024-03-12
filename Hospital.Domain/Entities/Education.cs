using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
    public class Education : BaseEntitiy
	{
        //Doctor's Education
        public string Year { get; set; }

        public string University { get; set; }

        public string Explanation { get; set; }

        [ForeignKey(nameof(Doctor.Id))]
        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

    }
}

﻿using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Doctor : AppUser
    {
		public string Speacialty { get; set; }

        public ICollection<DoctorPatient> DoctorPatients { get; set; }

		public int DepartmentId { get; set; }

		public Department Department { get; set; }

        [ForeignKey(nameof(Role.Id))]
        public string RoleId {  get; set; }
		public AppRole Role { get; set; }

		[ForeignKey(nameof(Introduction.Id))]
		public int IntroductionId {  get; set; }

        public Introduction Introduction { get; set; }
        public virtual ICollection<WorkingHour> WorkingHours { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }





    }
}

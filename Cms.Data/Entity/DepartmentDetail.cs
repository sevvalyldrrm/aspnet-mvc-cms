﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class DepartmentDetail
    {

        //Department Single
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        [NotMapped]
        public virtual ICollection<string> DepartmentFeatures { get; set; }


        [ForeignKey(nameof(Department.Id))]
        public int DepartmentId { get; set; }

        public Department Departments { get; set; }


    }
}

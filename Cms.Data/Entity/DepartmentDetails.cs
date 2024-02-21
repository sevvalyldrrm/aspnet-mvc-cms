using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class DepartmentDetails
    {

        //Department Single
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public string MySkills { get; set; }
        public ICollection<string> DepartmentFeatures { get; set; }
        public string WorkingDays { get; set; }//check-box
        public string WorkingHours { get; set; }
        public Department Department { get; set; }
        [ForeignKey(nameof(Department.Id))]
        public int DepartmentId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class Admin : AppUser
    {
        public string GitHubAcc { get; set; }
    }
}

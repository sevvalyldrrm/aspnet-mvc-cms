﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.CQRS.Results.AdminResults
{
    public class GetAdminByIdQueryResult : BaseResult
    {
        public string GitHubAcc { get; set; }
    }
}

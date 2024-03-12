using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.CQRS.Commands.AdminCommands
{
	public class CreateAdminCommand : IRequest
	{
		public string GitHubAcc { get; set; }
	}
}

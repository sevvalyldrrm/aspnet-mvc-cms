using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.CQRS.Commands.AdminCommands
{
	public class RemoveAdminCommand: IRequest
	{
		public int Id { get; set; }
		public RemoveAdminCommand(int id)
		{
			Id = id;
		}

	}
}

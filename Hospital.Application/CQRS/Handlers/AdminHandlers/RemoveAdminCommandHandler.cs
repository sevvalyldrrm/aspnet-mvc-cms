using Hospital.Application.CQRS.Commands.AdminCommands;
using Hospital.Application.CQRS.Results.AdminResults;
using Hospital.Application.Interfaces;
using Hospital.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.CQRS.Handlers.AdminHandlers
{
	public class RemoveAdminCommandHandler : IRequestHandler<RemoveAdminCommand>
	{
		private readonly IRepository<Admin> _repository;

		public RemoveAdminCommandHandler(IRepository<Admin> repository)
		{
			_repository = repository;
		}
		public async Task Handle(RemoveAdminCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}
}

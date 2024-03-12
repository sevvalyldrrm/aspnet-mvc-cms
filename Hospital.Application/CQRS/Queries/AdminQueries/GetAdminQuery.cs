using Hospital.Application.CQRS.Results.AdminResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.CQRS.Queries.AdminQueries
{
	public class GetAdminQuery : IRequest<List<GetAdminQueryResult>>
	{

	}
}

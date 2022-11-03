using eTickets.Data;
using eTickets.Models;
using eTicketss.Data.Base;

namespace eTicketss.Data.Services
{
	public class ProducersService:EntityBaseRepository<Producer>,IProducersService
	{
		public ProducersService(AppDbContext context): base(context)
		{	
		}
	}
}

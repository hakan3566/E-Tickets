using eTickets.Data;
using eTickets.Models;
using eTicketss.Data.Base;

namespace eTicketss.Data.Services
{
	public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService
	{
        public CinemasService(AppDbContext context) : base(context) { }
    }
}

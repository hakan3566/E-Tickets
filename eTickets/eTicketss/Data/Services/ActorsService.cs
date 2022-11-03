using eTickets.Data;
using eTickets.Models;
using eTicketss.Data.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketss.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        
        public ActorsService(AppDbContext context) : base(context) { }
        
       
    }
}

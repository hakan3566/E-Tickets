using eTickets.Models;
using eTicketss.Data.Base;
using eTicketss.Data.ViewModels;
using eTicketss.Models;
using System.Threading.Tasks;

namespace eTicketss.Data.Services
{
	public interface IMoviesService:IEntityBaseRepository<Movie>
	{
		Task<Movie> GetMovieByIdAsync(int id);
		Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
		Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetTop30HighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            var movie = await _dbContext.Movies.Include(m => m.Genres).FirstOrDefaultAsync(m => m.Id == id);

            // cast for that movie
            // Average Rating
            // Genres for that movie
            // Show Buy Button when user is not Login in the website and show when user is login and not purchased
            // Show Watch Movie button when user is login and already bought the movie
            // Include
            // ThenInclude

            // var rating = _dbContext.reviews.where(r => r.MovieId == id).AverageAync(r => r.Rating);
            // movie.Rating = rating;
            return movie;
        }

        //First()
        //FirstOrDefault()
        //Single()
        //SingleOrDefault()
        //Where()
        //GroupBy()
        //ToList()
        //Any()
    }
}
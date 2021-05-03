﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieServiceTest: IMovieService
    {
        public List<MovieResponseModel> GetTop30RevenueMovie()
        {
            var movies = new List<MovieResponseModel>
            {
                new() {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
                new() {Id = 2, Title = "Avatar", Budget = 1200000},
                new() {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
                new() {Id = 4, Title = "Titanic", Budget = 1200000},
                new() {Id = 5, Title = "Inception", Budget = 1200000},
                new() {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
                new() {Id = 7, Title = "Interstellar", Budget = 1200000},
                new() {Id = 8, Title = "Fight Club", Budget = 1200000},
                new() {Id = 14, Title = "Harry Potter and the Philosopher's Stone", Budget = 1200000},
                new() {Id = 15, Title = "Iron Man", Budget = 1200000},
                new() {Id = 16, Title = "Furious 7", Budget = 1200000}
            };
            return movies;
        }
    }
}
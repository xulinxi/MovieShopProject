import { Component, OnInit } from '@angular/core';
// Added imports
import { MovieCard } from 'src/app/shared/models/movieCard';
import { MovieService } from 'src/app/core/services/movie.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-movie-card-list',
  templateUrl: './movie-card-list.component.html',
  styleUrls: ['./movie-card-list.component.css']
})
export class MovieCardListComponent implements OnInit {

  movies: MovieCard[] | undefined;
  genreId: number | undefined;
  // route: any;

  constructor(private movieService: MovieService, private route: ActivatedRoute) { }

  //  ngOnInit() {
  //   this.route.paramMap.subscribe(
  //     (      params: { get: (arg0: string) => string | number; }) => {
  //       this.genreId = +params.get('id');
  //       this.MovieService.getMoviesByGenre(this.genreId)
  //         .subscribe(g => {
  //           this.movies = g;
  //         });
  //     }
  //   );
  // }

  ngOnInit() {
    
  }

}

import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  // talk with Movie api
  constructor(private apiService: ApiService) { }

  // Called by Movie Details Component
  getMovieDetails(id: number) {

    this.apiService.getOne(`${'movies/'}`, id);
 }

 getTopRevenueMovies(): Observable<MovieCard[]> {

  return this.apiService.getList('movies/toprevenue')

}
}

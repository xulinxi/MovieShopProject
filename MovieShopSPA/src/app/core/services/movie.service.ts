import { Injectable } from '@angular/core';
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


}

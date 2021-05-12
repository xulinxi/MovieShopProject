import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private apiService: ApiService) { }

  getAllGenres() {

    // api url (backend)
    // https://localhost:44385/api/
    this.apiService.getList(environment.apiUrl);
    // call getList() from apo service
  }
}

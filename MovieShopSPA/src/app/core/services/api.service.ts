import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  // HttpClient => used to communicate with API
  constructor(protected http: HttpClient) { }


  // getting array of json objects
  getList() {

  }

  // get single json object movie/id
  getOne() {

  }

  // post something
  create() {

  }

  // PUT
  update() {

  }

  // DELETE
  delete() {

  }

}

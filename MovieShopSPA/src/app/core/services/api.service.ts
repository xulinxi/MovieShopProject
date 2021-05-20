import { Injectable } from '@angular/core';
import {
  HttpClient,
  HttpHeaderResponse,
  HttpHeaders,
} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private headers: HttpHeaders | undefined;

  // HttpClient => used to communicate with API
  constructor(protected http: HttpClient) {}

  // getting array of json objects

  getList(path: string): Observable<any[]> {
    // var apiUrl = environment.apiUrl;
    // call only urls that get json array from API
    return this.http
      .get(`${environment.apiUrl}${path}`)
      .pipe(map((resp) => resp as any[]));
  }

  // get single json object movie/id
  getOne(path: string, id?: number) {
    return this.http
      .get(`${environment.apiUrl}${path}` + id)
      .pipe(map((resp) => resp as any));
  }

  // post something
  create(path: string, resource: any, options?: any): Observable<any> {
    return this.http
      .post(`${environment.apiUrl}${path}`, resource, { headers: this.headers })
      .pipe(map((response) => response));
  }
  // // post something
  // create() {

  // }

  // PUT
  update() {}

  // DELETE
  delete() {}
}

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Cons, retry } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';


export class serviceGeneric<T> {
  header: any = { 'content-type': 'application/json' };
  constructor(private httpClient: HttpClient) {}
  public headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '**',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Access-Control-Allow-Methods': 'GET, POST, PUT, DELETE, OPTIONS',
  });
  adicionar(apiUrl: string, objeto: T): Observable<T> {
    return this.httpClient.post<T>(apiUrl, JSON.stringify(objeto), {
      headers: this.headers,
    });
  }


  update(apiUrl: string, objeto: any): Observable<any> {
    return this.httpClient.put(apiUrl, JSON.stringify(objeto), {
      headers: this.headers,
    });
  }

  obterAll(apiUrl: string): Observable<T[]> {
    return this.httpClient.get<T[]>(apiUrl).pipe(retry(2));
  }

}


import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, Observable, retry } from 'rxjs';

import { serviceGeneric } from 'src/app/Service/serviceGeneric';
import { Estados } from '../models/estados';
import { API_URL } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class CadastroService extends serviceGeneric<any> {
  constructor(private http: HttpClient) {
    super(http);
  }
  obterTodos(): Observable<any[]> {
    return this.obterAll(API_URL);
  }

  obterPorNome(nome:string): Observable<any[]> {
    return this.obterAll(API_URL+"BuscarPorNome?nome="+nome);
  }

   obterCidades(): Observable<Estados[]> {
    return this.obterAll('https://servicodados.ibge.gov.br/api/v1/localidades/estados/');
  }
}

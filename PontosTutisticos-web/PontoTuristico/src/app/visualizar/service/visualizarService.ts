
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, Observable, retry } from 'rxjs';

import { serviceGeneric } from 'src/app/Service/serviceGeneric';
import { API_URL } from 'src/environments/environment';
import { PontoTuristico } from 'src/app/cadastro/models/PontoTuristico';
import { Estados } from 'src/app/cadastro/models/estados';

@Injectable({
  providedIn: 'root',
})
export class VizualizarService extends serviceGeneric<any> {
  constructor(private http: HttpClient) {
    super(http);
  }
  obterTodos(): Observable<any[]> {
    return this.obterAll('');
  }

   obterCidades(id:number): Observable<Estados[]> {
    return this.obterAll("https://servicodados.ibge.gov.br/api/v1/localidades/estados/"+id);
  }

  obterPorID(id:number): Observable<PontoTuristico[]> {
    return this.obterAll(API_URL+id);
  }

}

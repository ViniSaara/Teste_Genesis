import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { HttpHeaders } from '@angular/common/http';  
import { Observable } from 'rxjs';  
import { CdbModel } from './tela-cdb/cdb.model';

var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class CdbService {

  //url = 'https://localhost:44328/api/cdb';
  url = 'https://localhost:44399/api/cdb';

  constructor(private http: HttpClient) { }

  calcularCdb(meses: number, valorInicial: number): Observable<CdbModel> {  
    const apiurl = `${this.url}?meses=${meses}&valorInicial=${valorInicial}`;
    return this.http.get<CdbModel>(apiurl);
  }
}

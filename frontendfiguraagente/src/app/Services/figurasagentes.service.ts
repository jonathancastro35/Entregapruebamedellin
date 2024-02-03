import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Figuraagente } from '../Modelo/figuraagente';
import { environment } from '../environments/environments';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class FigurasagentesService {

  private endpoint:string = environment.endPointfiguraagente;

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
    'Content-Type': 'application/json',   
    }),
  };

  
  Generarfigura(data:any):Observable<Figuraagente>{
    return this.http
    .post<Figuraagente>(
     this.endpoint,JSON.stringify(data),
     this.httpOptions 
    )
    .pipe(retry(1),catchError(this.errorHandl))
    }

   
  errorHandl(error:any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(() => {
      return errorMessage;
    });
  }

  httpError(){
    return "Se ha producido un error en la aplicación consulte al administrador"
  }
}









import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


import { DemandRequest } from '../models/DemandRequest';


@Injectable({
  providedIn: 'root'
})

export class DemandRequestService {
  private readonly baseApiRoute: string = 'api/demandRequest';

  constructor(private http: HttpClient) { }

  public getDemandRequest(): Observable<DemandRequest[]> {
    return this.http.get<DemandRequest[]>(this.baseApiRoute);
  }

  public createDemandRequest(demandRequst: DemandRequest): Observable<void | string> {
    const options = {
      headers: new HttpHeaders({
        'Content-Type' : 'application/json'
      }),
    }
    return this.http.post<void>(this.baseApiRoute, demandRequst, options);
  }
}

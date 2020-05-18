import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Variables} from 'src/app/variables';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  constructor(private httpClient: HttpClient) {}

  getVariables(pattern: string): Observable<string> {
    return this.httpClient
      .get<string>('https://localhost:44390/api/Pattern/' + pattern);
  }
}

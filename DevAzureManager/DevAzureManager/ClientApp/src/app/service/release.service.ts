import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { TOKEN, LOGIN } from '../releases/releases-login/releases-login.component';
import { Release } from '../model/Release.model';
import { Approve } from '../model/Approve.model';

@Injectable({
  providedIn: 'root'
})
export class ReleaseService {

    constructor(private http: HttpClient) { }

    baseUrl = window.location.href + `/approvals/${localStorage.getItem(LOGIN)}/${localStorage.getItem(TOKEN)}`;

    getAllReleases(ambiente: string, nomeAplicacao: string): Observable<Release> {
      return this.http.get<Release>(`${this.baseUrl}?ambiente=${ambiente}&nomeAplicacao=${nomeAplicacao}`);
    }

    approveReleases(approves: Approve[]) {
      return this.http.post(`${this.baseUrl}`, approves);
    }
}

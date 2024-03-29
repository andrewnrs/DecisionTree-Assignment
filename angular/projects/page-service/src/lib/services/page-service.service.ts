import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PageServiceService {
  apiName = 'PageService';

  constructor(private restService: RestService) {}

  pages(): Observable<Page> {
    const data = this.restService.request<void, any>(
      { method: 'GET', url: '/api/page-service/pages' },
      { apiName: this.apiName },
    );

    return data;
  }

  homepage() {
    return this.restService.request<void, Page>(
      { method: 'GET', url: '/api/page-service/pages/home-page' },
      { apiName: this.apiName }
    );
  }
}

export interface Page{
  title: string;
  slug: string;
  content: string;
  script: string;
  style: string;
  home: boolean;
}

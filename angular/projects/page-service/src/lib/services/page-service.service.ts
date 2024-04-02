import { Injectable, Input } from '@angular/core';
import { RestService } from '@abp/ng.core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PageServiceService {
  apiName = 'PageService';

  constructor(private restService: RestService) {}

  getAll(): Observable<Page> {
    const data = this.restService.request<void, any>(
      { method: 'GET', url: '/api/page-service/pages' },
      { apiName: this.apiName },
    );

    return data;
  }

  getPageBySlug(slug: string) {
    return this.restService.request<void, Page>(
      { method: 'GET', url: `/api/page-service/pages/${slug}`},
      { apiName: this.apiName }
    );
  }

  post(input: any){
    return this.restService.request<Page, any>({
      method: 'POST',
      url: '/api/page-service/pages',
      body: input as Page
    });
  }
}

export interface Page{
  id: string;
  title: string;
  slug: string;
  content: string;
  home: boolean;
}

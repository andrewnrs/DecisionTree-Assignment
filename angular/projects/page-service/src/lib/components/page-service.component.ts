import { Component, OnInit } from '@angular/core';
import { Page, PageServiceService } from '../services/page-service.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'lib-page-service',
  template: `<div style="background:#FFF000; align-items: center;  justify-content: center;  display: flex;"> 
              <span [innerHTML]="(html | async)?.content"></span>              
            </div>`,
  styles: [],
})
export class PageServiceComponent implements OnInit {

  constructor(private service: PageServiceService) {}
  
  teste: string = `<h6>testando</h6>`;
  page$: Observable<Page> = new Observable<Page>();
  html: Observable<Page> = new Observable<Page>();

  ngOnInit(): void {
    this.page$ = this.service.pages().pipe(
      response => {
        //response.subscribe(console.log);
        return response;
      }
    );

    this.getHtml();
  }

  getHtml() {
    this.html =this.service.homepage().pipe(
      response => {
        response.subscribe(
          page => {
            console.log("page:", page)
            //this.html = page.content;
          }
        )
        return response;
      }
    )
  }

}

import { Component, OnInit } from '@angular/core';
import { PageServiceService } from '../services/page-service.service';

@Component({
  selector: 'lib-page-service',
  template: ` <p>page-service works!</p> `,
  styles: [],
})
export class PageServiceComponent implements OnInit {
  constructor(private service: PageServiceService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}

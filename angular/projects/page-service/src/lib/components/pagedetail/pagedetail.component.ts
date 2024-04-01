import { Component, Input, OnInit } from '@angular/core';
import { PageServiceService, Page } from '../../services/page-service.service';

@Component({
  selector: 'lib-abp-pagedetail',
  standalone: true,
  imports: [],
  templateUrl: './pagedetail.component.html',
  styleUrl: './pagedetail.component.css'
})
export class PagedetailComponent implements OnInit{

  //set [page]="yourVariable"
  @Input()
  page: Page;

  //set [slug]="yourVariable"
  @Input()
  slug: string;

  constructor(private service: PageServiceService) {
      console.log('constructor page: ', this.slug);
  }

  ngOnInit() {
    console.log('init page: ', this.page);
    console.log('init slug: ', this.slug);
  }


}

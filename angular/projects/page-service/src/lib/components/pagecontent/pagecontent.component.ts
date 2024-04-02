import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'lib-abp-pagecontent',
  templateUrl: './pagecontent.component.html',
  styleUrl: './pagecontent.component.css'
})
export class PagecontentComponent implements OnInit{

  @Input()
  content: string;

  isModalOpen: boolean;

  ngOnInit(): void {
    this.isModalOpen = false;
  }
}

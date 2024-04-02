import { Component, OnInit, ChangeDetectorRef, Input, TemplateRef, ViewChild  } from '@angular/core';
import { PageServiceService } from '../services/page-service.service';
import { SubscriptionService } from '@abp/ng.core';
import { ColumnMode } from '@swimlane/ngx-datatable';

@Component({
  selector: 'lib-page-service',
  templateUrl: './page-service.component.html',
  styleUrl: './page-service.component.css',
  styles: [],
  providers: []
})
export class PageServiceComponent implements OnInit {

  constructor(private service: PageServiceService, private subscription: SubscriptionService) {
    //this.subscription.addOne(this.count$, console.log);
  }
  //page$: Observable<Page> = new Observable<Page>();

  newPageBtnTxt = "NEW";
  editPageBtnTxt = "EDIT";

  ColumnMode = ColumnMode;

  data = [];
  cols = [];

  @Input() mode:string = 'page'
  @ViewChild('slugTmpl', { static: true }) slugTmpl: TemplateRef<any>;
  @ViewChild('titleTmpl', { static: true }) titleTmpl: TemplateRef<any>;
  @ViewChild('contentTmpl', { static: true }) contentTmpl: TemplateRef<any>;
  @ViewChild('editTmpl', { static: true }) editTmpl: TemplateRef<any>;
  @ViewChild('homeTmpl', { static: true }) homeTmpl: TemplateRef<any>;
  @ViewChild('hdrTpl', { static: true }) hdrTpl: TemplateRef<any>;

  ngOnInit(): void {

    this.cols = [
      {
        cellTemplate: this.titleTmpl,
        headerTemplate: this.hdrTpl,
        name: 'Title'
      },
      {
        cellTemplate: this.slugTmpl,
        headerTemplate: this.hdrTpl,
        name: 'Slug',
      },
      {
        cellTemplate: this.homeTmpl,
        headerTemplate: this.hdrTpl,
        name: 'Is Home Page'
      },
      {
        cellTemplate: this.contentTmpl,
        headerTemplate: this.hdrTpl,
        name: 'Content'
      },
      {
        cellTemplate: this.editTmpl,
        headerTemplate: this.hdrTpl,
        name: 'data'
      }
    ];

    this.loadData()
  }

  loadData(): void {
    this.service.getAll().subscribe((data:any) => {
      this.data = data
    })
  }

  shouldUpdateTable(update: any){
    console.log('UPDATING ... ',update);

    if(update){
      this.loadData();
    }
  }
}

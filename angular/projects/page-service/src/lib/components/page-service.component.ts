import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Page, PageServiceService } from '../services/page-service.service';
import { Observable } from 'rxjs';
import { SubscriptionService } from '@abp/ng.core';

@Component({
  selector: 'lib-page-service',
  templateUrl: './page-service.component.html',
  styleUrl: './page-service.component.scss',
  styles: [],
  providers: []
})
export class PageServiceComponent implements OnInit {

  constructor(private service: PageServiceService, private subscription: SubscriptionService, private formBuilder: FormBuilder) {
    //this.subscription.addOne(this.count$, console.log);
  }

  htmlContent: "";

  inProgress: boolean;
  isModalOpen: boolean;

  pageForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(60)]],
    slug: ['', [Validators.required, Validators.maxLength(60)]],
    home: [],
    content: [''],
  });

  updateContent($event: any){
    //console.log($event);
    this.pageForm.value.content = $event.args[0];
    console.log(this.htmlContent);
  }

  submitForm() {
    console.log(this.pageForm.value);

    if (this.pageForm.invalid) return;

    this.inProgress = true;

    console.log("sending:",this.pageForm.value);

    this.service.postM(this.pageForm.value).subscribe(() => {
      this.resetForm();
    });
  }

  resetForm() {
      this.inProgress = false;
      this.isModalOpen = false;
      this.pageForm.reset();
  }

  page$: Observable<Page> = new Observable<Page>();
  html: Observable<Page> = new Observable<Page>();

  ngOnInit(): void {
    /*this.page$ = this.service.pages().pipe(
      response => {
        //response.subscribe(console.log);
        return response;
      }
    );*/

    //this.getHtml();


    return
  }

  getContent() {
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

  getHtml() {
    this.html = this.service.homepage().pipe(
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

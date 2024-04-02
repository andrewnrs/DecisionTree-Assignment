import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PageServiceService } from '../../services/page-service.service';

@Component({
  selector: 'lib-abp-pagedetail',
  templateUrl: './pagedetail.component.html',
  styleUrl: './pagedetail.component.css'
})
export class PagedetailComponent implements OnInit {

  constructor(private service: PageServiceService, private formBuilder: FormBuilder) {
  }

  ngOnInit(): void {
    console.log('label',this.buttonLabel);
  }

  //@Input()
  //id: string;

  @Input()
  page: any;

  @Input()
  buttonLabel: any;

  inProgress: boolean;
  isModalOpen: boolean;

  pageTitle: string;
  pageSlug: string;
  pageHome: boolean;
  pageContent: string;

  pageForm: FormGroup;

  initForm(){

    this.isModalOpen = true;

    this.pageForm = this.formBuilder.group({
      title: ['', [Validators.required, Validators.maxLength(60)]],
      slug: ['', [Validators.required, Validators.maxLength(60)]],
      isHomePage: [],
      content: [''],
    });

    if(this.page != undefined){
      this.pageTitle = this.page.title;
      this.pageSlug = this.page.slug;
      this.pageHome = this.page.isHomePage;
      this.pageContent = this.page.content;

      console.log('p',this.page);
      console.log('pc',this.pageContent);

      this.pageForm = this.formBuilder.group({
        id: [this.page.id],
        title: [this.page.title, [Validators.required, Validators.maxLength(60)]],
        slug: [this.page.slug, [Validators.required, Validators.maxLength(60)]],
        isHomePage: [this.page.home],
        content: [this.page.content],
      });
    }
  }

  updateContent($event: any){
    //console.log($event);
    this.pageForm.value.content = $event.args[0];
  }

  submitForm() {
    if (this.pageForm.invalid) return;

    this.inProgress = true;

    console.log("sending:",this.pageForm.value);

    this.service.post(this.pageForm.value).subscribe(() => {
      this.resetForm();
    });
  }

  resetForm() {
      this.inProgress = false;
      this.isModalOpen = false;
      this.pageForm.reset();
  }

}

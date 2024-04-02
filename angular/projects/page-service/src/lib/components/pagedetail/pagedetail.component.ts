import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { PageServiceService } from '../../services/page-service.service';

@Component({
  selector: 'lib-abp-pagedetail',
  templateUrl: './pagedetail.component.html',
  styleUrl: './pagedetail.component.css'
})
export class PagedetailComponent {

  constructor(private service: PageServiceService, private formBuilder: FormBuilder, private builder: FormBuilder) {
    this.pageForm = this.builder.group({
    myJodit: new FormControl('')
    });
  }

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
      content: new FormControl('')
    });

    if(this.page != undefined){
      this.pageTitle = this.page.title;
      this.pageSlug = this.page.slug;
      this.pageHome = this.page.isHomePage;
      this.pageContent = this.page.content;

      this.pageForm = this.formBuilder.group({
        id: [this.page.id],
        title: [this.page.title, [Validators.required, Validators.maxLength(60)]],
        slug: [this.page.slug, [Validators.required, Validators.maxLength(60)]],
        isHomePage: [this.page.isHomePage],
        content: new FormControl(''),
      });

      this.pageForm.controls.content.setValue(this.page.content);
    }
  }

  updateContent($event: any){
    this.pageForm.controls.content.setValue($event.args[0]);
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

import { Component, EventEmitter, OnChanges, OnDestroy, OnInit, Output } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { PageServiceService } from '../../services/page-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'lib-abp-newpage',
  templateUrl: './newpage.component.html',
  styleUrl: './newpage.component.css',

})
export class NewpageComponent  {

  constructor(private service: PageServiceService, private formBuilder: FormBuilder) {
  }

  inProgress: boolean;
  isModalOpen: boolean;

  pageForm = this.formBuilder.group({
    title: ['', [Validators.required, Validators.maxLength(60)]],
    slug: ['', [Validators.required, Validators.maxLength(60)]],
    isHomePage: [],
    content: [''],
  });

  updateContent($event: any){
    //console.log($event);
    this.pageForm.value.content = $event.args[0];
  }

  submitForm() {
    if (this.pageForm.invalid) return;

    this.inProgress = true;
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

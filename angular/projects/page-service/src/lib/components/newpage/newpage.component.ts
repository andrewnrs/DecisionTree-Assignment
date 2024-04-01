import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { PageServiceService } from '../../services/page-service.service';

@Component({
  selector: 'lib-abp-newpage',
  //standalone: true,
  //imports: [],
  templateUrl: './newpage.component.html',
  styleUrl: './newpage.component.css',

})
export class NewpageComponent implements OnInit {

  constructor(private service: PageServiceService, private formBuilder: FormBuilder) {
  }

  ngOnInit(): void {
    return
  }

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

}

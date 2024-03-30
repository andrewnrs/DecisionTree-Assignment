import { NgModule } from '@angular/core';
import { RouterOutletComponent } from '@abp/ng.core';
import { Routes, RouterModule } from '@angular/router';
import { PageServiceComponent } from './components/page-service.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'prefix',
    component: RouterOutletComponent,
    children: [
      {
        path: '',
        component: PageServiceComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PageServiceRoutingModule {}

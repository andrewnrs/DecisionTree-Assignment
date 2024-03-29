import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { PageServiceModule } from '@page-service';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule, PageServiceModule],
})
export class HomeModule {}

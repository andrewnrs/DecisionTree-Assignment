import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { PageServiceComponent } from './components/pageservice/page-service.component';
import { PagedetailComponent } from './components/pagedetail/pagedetail.component';
import { PagecontentComponent } from './components/pagecontent/pagecontent.component';
import { PageServiceRoutingModule } from './page-service-routing.module';
import { JoditAngularModule } from 'jodit-angular';
import { PageModule } from '@abp/ng.components/page';

@NgModule({
  declarations: [PageServiceComponent, PagedetailComponent, PagecontentComponent],
  imports: [CoreModule, ThemeSharedModule, PageServiceRoutingModule, JoditAngularModule, PageModule],
  exports: [PageServiceComponent, PagedetailComponent, PagecontentComponent],
})
export class PageServiceModule {
  static forChild(): ModuleWithProviders<PageServiceModule> {
    return {
      ngModule: PageServiceModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<PageServiceModule> {
    return new LazyModuleFactory(PageServiceModule.forChild());
  }
}

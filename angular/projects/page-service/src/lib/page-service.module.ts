import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { PageServiceComponent } from './components/page-service.component';
import { PageServiceRoutingModule } from './page-service-routing.module';
import { JoditAngularModule } from 'jodit-angular';
import { PageModule } from '@abp/ng.components/page';

@NgModule({
  declarations: [PageServiceComponent],
  imports: [CoreModule, ThemeSharedModule, PageServiceRoutingModule, JoditAngularModule, PageModule],
  exports: [PageServiceComponent],
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

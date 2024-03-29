import { ModuleWithProviders, NgModule } from '@angular/core';
import { PAGE_SERVICE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class PageServiceConfigModule {
  static forRoot(): ModuleWithProviders<PageServiceConfigModule> {
    return {
      ngModule: PageServiceConfigModule,
      providers: [PAGE_SERVICE_ROUTE_PROVIDERS],
    };
  }
}

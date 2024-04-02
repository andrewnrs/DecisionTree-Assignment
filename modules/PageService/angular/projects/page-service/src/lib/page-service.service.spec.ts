import { TestBed } from '@angular/core/testing';
import { PageServiceService } from './services/page-service.service';
import { RestService } from '@abp/ng.core';

describe('PageServiceService', () => {
  let service: PageServiceService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(PageServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

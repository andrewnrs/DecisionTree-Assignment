import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { PageServiceComponent } from './components/pageservice/page-service.component';
import { PageServiceService } from '@page-service';
import { of } from 'rxjs';

describe('PageServiceComponent', () => {
  let component: PageServiceComponent;
  let fixture: ComponentFixture<PageServiceComponent>;
  const mockPageServiceService = jasmine.createSpyObj('PageServiceService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [PageServiceComponent],
      providers: [
        {
          provide: PageServiceService,
          useValue: mockPageServiceService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PageServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateHcsComponent } from './create-hcs.component';

describe('CreateHcsComponent', () => {
  let component: CreateHcsComponent;
  let fixture: ComponentFixture<CreateHcsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateHcsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateHcsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

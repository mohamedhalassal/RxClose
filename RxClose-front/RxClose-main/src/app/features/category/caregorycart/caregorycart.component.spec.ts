import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CaregorycartComponent } from './caregorycart.component';

describe('CaregorycartComponent', () => {
  let component: CaregorycartComponent;
  let fixture: ComponentFixture<CaregorycartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CaregorycartComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CaregorycartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

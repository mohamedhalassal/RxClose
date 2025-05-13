import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CaregorylistComponent } from './caregorylist.component';

describe('CaregorylistComponent', () => {
  let component: CaregorylistComponent;
  let fixture: ComponentFixture<CaregorylistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CaregorylistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CaregorylistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

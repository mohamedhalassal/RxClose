import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CartSimilarsingsComponent } from './cart-similarsings.component';

describe('CartSimilarsingsComponent', () => {
  let component: CartSimilarsingsComponent;
  let fixture: ComponentFixture<CartSimilarsingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CartSimilarsingsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CartSimilarsingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

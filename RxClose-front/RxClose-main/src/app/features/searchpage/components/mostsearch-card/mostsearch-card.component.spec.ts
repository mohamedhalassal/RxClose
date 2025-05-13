import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MostsearchCardComponent } from './mostsearch-card.component';

describe('MostsearchCardComponent', () => {
  let component: MostsearchCardComponent;
  let fixture: ComponentFixture<MostsearchCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MostsearchCardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MostsearchCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

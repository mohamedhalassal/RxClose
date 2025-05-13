import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MostsearchListComponent } from './mostsearch-list.component';

describe('MostsearchListComponent', () => {
  let component: MostsearchListComponent;
  let fixture: ComponentFixture<MostsearchListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MostsearchListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MostsearchListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

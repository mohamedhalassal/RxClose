import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConvertAiComponent } from './convert-ai.component';

describe('ConvertAiComponent', () => {
  let component: ConvertAiComponent;
  let fixture: ComponentFixture<ConvertAiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConvertAiComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConvertAiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TendenciacentralComponent } from './tendenciacentral.component';

describe('TendenciacentralComponent', () => {
  let component: TendenciacentralComponent;
  let fixture: ComponentFixture<TendenciacentralComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TendenciacentralComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TendenciacentralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

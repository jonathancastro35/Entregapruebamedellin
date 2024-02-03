import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FiguraagenteComponent } from './figuraagente.component';

describe('FiguraagenteComponent', () => {
  let component: FiguraagenteComponent;
  let fixture: ComponentFixture<FiguraagenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FiguraagenteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FiguraagenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

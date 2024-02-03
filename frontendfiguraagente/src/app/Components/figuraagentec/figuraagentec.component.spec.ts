import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FiguraagentecComponent } from './figuraagentec.component';

describe('FiguraagentecComponent', () => {
  let component: FiguraagentecComponent;
  let fixture: ComponentFixture<FiguraagentecComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FiguraagentecComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FiguraagentecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

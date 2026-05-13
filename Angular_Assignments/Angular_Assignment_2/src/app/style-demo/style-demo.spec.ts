import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StyleDemo } from './style-demo';

describe('StyleDemo', () => {
  let component: StyleDemo;
  let fixture: ComponentFixture<StyleDemo>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StyleDemo],
    }).compileComponents();

    fixture = TestBed.createComponent(StyleDemo);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

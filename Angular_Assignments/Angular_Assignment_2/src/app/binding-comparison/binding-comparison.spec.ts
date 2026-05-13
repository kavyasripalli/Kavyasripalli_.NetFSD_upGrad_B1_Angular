import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BindingComparison } from './binding-comparison';

describe('BindingComparison', () => {
  let component: BindingComparison;
  let fixture: ComponentFixture<BindingComparison>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BindingComparison],
    }).compileComponents();

    fixture = TestBed.createComponent(BindingComparison);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

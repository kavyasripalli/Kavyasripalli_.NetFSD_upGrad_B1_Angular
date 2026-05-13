import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicPhones } from './dynamic-phones';

describe('DynamicPhones', () => {
  let component: DynamicPhones;
  let fixture: ComponentFixture<DynamicPhones>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DynamicPhones],
    }).compileComponents();

    fixture = TestBed.createComponent(DynamicPhones);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

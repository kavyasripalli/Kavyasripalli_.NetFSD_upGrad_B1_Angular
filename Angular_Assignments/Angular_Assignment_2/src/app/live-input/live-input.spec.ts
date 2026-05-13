import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LiveInput } from './live-input';

describe('LiveInput', () => {
  let component: LiveInput;
  let fixture: ComponentFixture<LiveInput>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LiveInput],
    }).compileComponents();

    fixture = TestBed.createComponent(LiveInput);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

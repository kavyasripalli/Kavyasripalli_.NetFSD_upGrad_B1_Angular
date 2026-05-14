import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductDetailsChild } from './product-details-child';

describe('ProductDetailsChild', () => {
  let component: ProductDetailsChild;
  let fixture: ComponentFixture<ProductDetailsChild>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductDetailsChild],
    }).compileComponents();

    fixture = TestBed.createComponent(ProductDetailsChild);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

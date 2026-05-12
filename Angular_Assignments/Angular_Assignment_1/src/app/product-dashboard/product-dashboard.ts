import { Component } from '@angular/core';

import { CommonModule } from '@angular/common';

import { FormsModule } from '@angular/forms';

import { Product } from '../models/product';

@Component({
  selector: 'app-product-dashboard',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './product-dashboard.html',
  styleUrl: './product-dashboard.css'
})
export class ProductDashboard {

  products: Product[] = [

    {
      id: 1,
      name: 'Laptop',
      price: 50000,
      quantity: 5
    },

    {
      id: 2,
      name: 'Mobile',
      price: 20000,
      quantity: 0
    }

  ];

  newProduct: Product = {

    id: 0,
    name: '',
    price: 0,
    quantity: 0

  };

  addProduct() {

    this.products.push({ ...this.newProduct });

    this.newProduct = {
      id: 0,
      name: '',
      price: 0,
      quantity: 0
    };

  }

}
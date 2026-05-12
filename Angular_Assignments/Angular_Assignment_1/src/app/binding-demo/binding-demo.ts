import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Product } from '../models/product';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-binding-demo',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './binding-demo.html',
  styleUrl: './binding-demo.css'
})
export class BindingDemo {

  isLoggedIn: boolean = false;

  courses: string[] = [
  'Angular',
  'React',
  '.NET'
];

  studentName: string = "Kavya";

  imageUrl: string =
    "https://angular.io/assets/images/logos/angular/angular.png";

  name: string = "";
  email: string = "";

  showMessage() {
    alert("Button Clicked!");

  }

  toggleLogin() {
  this.isLoggedIn = !this.isLoggedIn;
}

  products: Product[] = [

  {
    id: 1,
    name: 'Laptop',
    price: 50000,
    quantity: 2
  },

  {
    id: 2,
    name: 'Mobile',
    price: 20000,
    quantity: 5
  },

  {
    id: 3,
    name: 'Headphones',
    price: 3000,
    quantity: 10
  }

  ];
  }
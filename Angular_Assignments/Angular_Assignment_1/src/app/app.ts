import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BindingDemo } from './binding-demo/binding-demo';
import { FormsModule } from '@angular/forms';
import { Student } from './student/student';
import { Header } from './header/header';
import { Footer } from './footer/footer';
import { Dashboard } from './dashboard/dashboard';
import { ProductDashboard } from './product-dashboard/product-dashboard';

@Component({
  selector: 'app-root',
  imports: [
  RouterOutlet,
  BindingDemo,
  FormsModule,
  Student,
  Header,
  Footer,
  Dashboard,
  ProductDashboard
],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Angular_Assignment_1');
}

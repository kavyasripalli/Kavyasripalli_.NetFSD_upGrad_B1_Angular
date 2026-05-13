import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserProfile } from './user-profile/user-profile';
import { ImageGallery } from './image-gallery/image-gallery';
import { Counter } from './counter/counter';
import { LiveInput } from './live-input/live-input';
import { BindingComparison } from './binding-comparison/binding-comparison';
import { LoginStatus } from './login-status/login-status';
import { ProductList } from './product-list/product-list';
import { TaskList } from './task-list/task-list';
import { StyleDemo } from './style-demo/style-demo';
import { DirectiveDemo } from './directive-demo/directive-demo';
import { RegistrationForm } from './registration-form/registration-form';
import { ReactiveLogin } from './reactive-login/reactive-login';
import { DynamicPhones } from './dynamic-phones/dynamic-phones';
import { StudentManagement } from './student-management/student-management';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, UserProfile, ImageGallery, 
    Counter, LiveInput, BindingComparison, LoginStatus, 
    ProductList, TaskList, StyleDemo, DirectiveDemo, RegistrationForm, 
    ReactiveLogin, DynamicPhones, StudentManagement],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Angular_Assignment_2');
}

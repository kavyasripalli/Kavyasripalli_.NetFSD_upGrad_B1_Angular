import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-registration-form',
  imports: [FormsModule, CommonModule],
  templateUrl: './registration-form.html',
  styleUrl: './registration-form.css',
})
export class RegistrationForm {
  name: string = '';

email: string = '';

password: string = '';

onSubmit() {

  console.log('Form Submitted');

  console.log(this.name);

  console.log(this.email);

  console.log(this.password);

}
}

import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { FormGroup } from '@angular/forms';

import { FormControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-reactive-login',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './reactive-login.html',
  styleUrl: './reactive-login.css',
})
export class ReactiveLogin {
  loginForm = new FormGroup({

  email: new FormControl(
    '',
    [
      Validators.required,
      Validators.email
    ]
  ),

  password: new FormControl(
    '',
    [
      Validators.required,
      Validators.minLength(6)
    ]
  )

});
onSubmit() {

  console.log(this.loginForm.value);

}
}

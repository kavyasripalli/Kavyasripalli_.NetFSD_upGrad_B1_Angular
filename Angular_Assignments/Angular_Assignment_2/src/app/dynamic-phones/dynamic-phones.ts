import { Component } from '@angular/core';
import {
  ReactiveFormsModule,
  FormGroup,
  FormControl,
  FormArray
} from '@angular/forms';

import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dynamic-phones',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './dynamic-phones.html',
  styleUrl: './dynamic-phones.css',
})
export class DynamicPhones {
  phoneForm = new FormGroup({

  phones: new FormArray([
    new FormControl('')
  ])

});
get phones() {

  return this.phoneForm.get('phones') as FormArray;

}
addPhone() {

  this.phones.push(
    new FormControl('')
  );

}

removePhone(index: number) {

  this.phones.removeAt(index);

}

onSubmit() {

  console.log(this.phoneForm.value);

}
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css',
})
export class Student {

  name: string = "Kavya";

age: number = 22;

course: string = "Angular";
}

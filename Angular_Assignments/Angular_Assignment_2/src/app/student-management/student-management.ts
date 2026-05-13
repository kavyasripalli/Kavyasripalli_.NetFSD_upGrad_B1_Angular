import { Component } from '@angular/core';

import { CommonModule } from '@angular/common';

import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-management',
  imports: [CommonModule, FormsModule],
  templateUrl: './student-management.html',
  styleUrl: './student-management.css',
})
export class StudentManagement {
  students = [

  {
    name: 'Kavya',
    course: 'Angular',
    marks: 90
  },

  {
    name: 'Rahul',
    course: '.NET',
    marks: 30
  }

];

newStudent = {

  name: '',

  course: '',

  marks: 0

};

searchText: string = '';

addStudent() {

  this.students.push({
    ...this.newStudent
  });

  this.newStudent = {

    name: '',

    course: '',

    marks: 0

  };

}
}

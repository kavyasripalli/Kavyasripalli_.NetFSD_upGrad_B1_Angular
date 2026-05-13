import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
})
export class TaskList {
  tasks = [

  {
    name: 'Learn Angular',
    completed: true
  },

  {
    name: 'Practice TypeScript',
    completed: false
  },

  {
    name: 'Build Project',
    completed: true
  }

];
}

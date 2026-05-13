import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-binding-comparison',
  imports: [FormsModule],
  templateUrl: './binding-comparison.html',
  styleUrl: './binding-comparison.css',
})
export class BindingComparison {
  title: string = 'Angular';

imageUrl: string =
  'https://angular.io/assets/images/logos/angular/angular.png';

count: number = 0;

userName: string = '';

increaseCount() {
  this.count++;
}
}

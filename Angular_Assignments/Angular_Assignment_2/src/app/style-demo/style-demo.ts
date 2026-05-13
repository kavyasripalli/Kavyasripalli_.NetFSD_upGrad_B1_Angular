import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-style-demo',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './style-demo.html',
  styleUrl: './style-demo.css',
})
export class StyleDemo {
  fontSize: number = 20;

textColor: string = 'black';

increaseSize() {
  this.fontSize += 5;
}

changeColor(color: string) {
  this.textColor = color;
}
}

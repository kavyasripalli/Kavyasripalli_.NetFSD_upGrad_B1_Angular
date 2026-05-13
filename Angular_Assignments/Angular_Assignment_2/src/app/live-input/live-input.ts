import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-live-input',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './live-input.html',
  styleUrl: './live-input.css',
})
export class LiveInput {
  userName: string = '';
}

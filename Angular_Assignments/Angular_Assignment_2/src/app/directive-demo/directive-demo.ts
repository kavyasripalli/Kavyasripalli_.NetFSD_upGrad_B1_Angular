import { Component } from '@angular/core';
import { Highlight } from '../highlight';

@Component({
  selector: 'app-directive-demo',
  standalone: true,
  imports: [Highlight],
  templateUrl: './directive-demo.html',
  styleUrl: './directive-demo.css',
})
export class DirectiveDemo {}

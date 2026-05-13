import { Component } from '@angular/core';

@Component({
  selector: 'app-image-gallery',
  imports: [],
  templateUrl: './image-gallery.html',
  styleUrl: './image-gallery.css',
})
export class ImageGallery {
  imageUrl: string =
  'https://angular.io/assets/images/logos/angular/angular.png';

  imageWidth: number = 250;

  imageHeight: number = 250;
}

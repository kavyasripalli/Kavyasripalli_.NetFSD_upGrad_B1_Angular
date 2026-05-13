import { Component } from '@angular/core';

@Component({
  selector: 'app-user-profile',
  imports: [],
  templateUrl: './user-profile.html',
  styleUrl: './user-profile.css',
})
export class UserProfile {
  userName: string = 'Kavya';

  email: string = 'kavya@gmail.com';

  role: string = 'Angular Developer';
}

import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HighlightDirective }
from '../../directives/highlight';
import {
DisableButtonDirective
}
from '../../directives/disable-button';

@Component({
  selector: 'app-student-dashboard',
  imports:[CommonModule, HighlightDirective, DisableButtonDirective],
  templateUrl: './student-dashboard.html',
  styleUrl: './student-dashboard.css',
})
export class StudentDashboard {
  students=[

{
name:'Kavya',
class:'10A',
marks:95,
absent:false
},

{
name:'Rahul',
class:'10B',
marks:75,
absent:true
},

{
name:'Priya',
class:'10C',
marks:30,
absent:false
}

];

getGrade(marks:number){

if(marks>=90){

return 'A';

}

else if(marks>=70){

return 'B';

}

else if(marks>=35){

return 'C';

}

else{

return 'Fail';

}

}
}

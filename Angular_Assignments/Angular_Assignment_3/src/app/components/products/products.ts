import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

import {
Router,
ActivatedRoute
}
from '@angular/router';

@Component({
  selector: 'app-products',
  imports:[
RouterLink,
CommonModule, RouterOutlet
],
  templateUrl: './products.html',
  styleUrl: './products.css',
})
export class Products {
  category='';

products=[

{
name:'Laptop',
category:'electronics'
},

{
name:'Mobile',
category:'electronics'
},

{
name:'Shirt',
category:'fashion'
}

];

filteredProducts=this.products;

constructor(

private router:Router,

private route:ActivatedRoute

){

this.route.queryParams.subscribe(

params=>{

this.category=
params['category'];

if(this.category){

this.filteredProducts=
this.products.filter(

p=>p.category===this.category

);

}

else{

this.filteredProducts=
this.products;

}

}

);

}

setCategory(category:string){

this.router.navigate(
[],
{

relativeTo:this.route,

queryParams:{category}

}

);

}
}

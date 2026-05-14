import { Component } from '@angular/core';

import { ActivatedRoute } from '@angular/router';

@Component({

selector:'app-product-details',

standalone:true,

templateUrl:'./product-details.html'

})
export class ProductDetails {

productId:any;

constructor(
private route:ActivatedRoute
){

this.productId=
this.route.snapshot.paramMap.get('id');

}

}
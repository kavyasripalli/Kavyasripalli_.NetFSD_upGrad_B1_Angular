import { Routes } from '@angular/router';

import { Products } from './components/products/products';
import { ProductDetails } from './components/product-details/product-details';
import { Cart } from './components/cart/cart';
import { PageNotFound } from './components/page-not-found/page-not-found';
import { ProductDetailsChild } from './components/product-details-child/product-details-child';
import { authGuard } from './guards/auth-guard';

import { ProductReviews } from './components/product-reviews/product-reviews';

export const routes: Routes = [

  {
path:'products',

component:Products,

children:[

{

path:'details',

component:ProductDetailsChild

},

{

path:'reviews',

component:ProductReviews

}

]

},

  {
    path:'products/:id',
    component:ProductDetails
  },

  {
    path:'cart',
    component:Cart
  },
  {
path:'checkout',

canActivate:[authGuard],

loadChildren:()=>import('./checkout/checkout.routes')
.then(m=>m.routes)

},
  {
    path:'**',
    component:PageNotFound
  }

];
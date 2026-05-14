import { CanActivateFn } from '@angular/router';

export const authGuard: CanActivateFn = () => {

  const isLoggedIn = false;

  if(isLoggedIn){

    return true;

  }

  else{

    alert('Please Login First');

    return false;

  }

};
import {

Directive,
Input,
HostBinding

}

from '@angular/core';

@Directive({

selector:'[appDisableButton]',

standalone:true

})

export class DisableButtonDirective{

@Input()

appDisableButton=false;

@HostBinding('disabled')

get disable(){

return this.appDisableButton;

}

}
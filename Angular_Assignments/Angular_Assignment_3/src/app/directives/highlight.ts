import {
Directive,
HostBinding,
HostListener
}
from '@angular/core';

@Directive({

selector:'[appHighlight]',

standalone:true

})

export class HighlightDirective{

@HostBinding(
'style.backgroundColor'
)

background='';

@HostListener('mouseenter')

mouseEnter(){

this.background='yellow';

}

@HostListener('mouseleave')

mouseLeave(){

this.background='';

}

}
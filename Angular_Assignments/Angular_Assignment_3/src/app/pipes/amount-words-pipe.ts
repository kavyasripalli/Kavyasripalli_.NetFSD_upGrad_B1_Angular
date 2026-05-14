import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name:'amountWords',
  standalone:true
})

export class AmountWordsPipe
implements PipeTransform{

transform(value:number):string{

const words:any={

50000:'Fifty Thousand',

2500:'Two Thousand Five Hundred',

12000:'Twelve Thousand'

};

return words[value] || value;

}

}
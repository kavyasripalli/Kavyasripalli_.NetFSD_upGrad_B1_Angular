import { Pipe, PipeTransform } from '@angular/core';

@Pipe({

name:'filterTransaction',

standalone:true

})

export class FilterTransactionPipe
implements PipeTransform{

transform(

transactions:any[],

amount:number

){

return transactions.filter(

t=>t.amount>amount

);

}

}
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name:'maskAccount',
  standalone:true
})

export class MaskAccountPipe
implements PipeTransform{

transform(value:string):string{

return 'XXXX'+value.slice(-4);

}

}
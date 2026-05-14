import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaskAccountPipe }
from '../../pipes/mask-account-pipe';
import { FilterTransactionPipe }
from '../../pipes/filter-transaction-pipe';
import { AmountWordsPipe }
from '../../pipes/amount-words-pipe';

@Component({
  selector: 'app-account-statement',
  imports:[CommonModule, MaskAccountPipe, FilterTransactionPipe, AmountWordsPipe ],
  templateUrl: './account-statement.html',
  styleUrl: './account-statement.css',
})
export class AccountStatement {

  accountHolder='KaVya SrI';
  interestRate = 0.085;
  accountNumber='1234567891234';

  transactions=[

    {
      name:'Salary',
      amount:50000,
      date:new Date()
    },

    {
      name:'Electricity Bill',
      amount:2500,
      date:new Date()
    },

    {
      name:'Shopping',
      amount:12000,
      date:new Date()
    }

  ];

}
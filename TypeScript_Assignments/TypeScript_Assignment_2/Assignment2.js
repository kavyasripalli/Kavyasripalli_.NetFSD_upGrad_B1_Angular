"use strict";
class CreditCardPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    pay() {
        console.log("Paid " +
            this.amount +
            " using Credit Card");
    }
    refund() {
        console.log("Refund initiated to Credit Card");
    }
}
class UPIPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    pay() {
        console.log("Paid " +
            this.amount +
            " using UPI");
    }
}
let credit = new CreditCardPayment(1000);
let upi = new UPIPayment(500);
credit.pay();
credit.refund();
upi.pay();

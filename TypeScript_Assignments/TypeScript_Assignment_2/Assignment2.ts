interface Payment {

    amount: number;

    pay(): void;
}

interface Refundable {

    refund(): void;
}

class CreditCardPayment
implements Payment, Refundable {

    amount: number;

    constructor(amount: number) {
        this.amount = amount;
    }

    pay(): void {
        console.log(
            "Paid " +
            this.amount +
            " using Credit Card"
        );
    }

    refund(): void {
        console.log(
            "Refund initiated to Credit Card"
        );
    }
}

class UPIPayment implements Payment {

    amount: number;

    constructor(amount: number) {
        this.amount = amount;
    }

    pay(): void {
        console.log(
            "Paid " +
            this.amount +
            " using UPI"
        );
    }
}

let credit = new CreditCardPayment(1000);

let upi = new UPIPayment(500);

credit.pay();

credit.refund();

upi.pay();
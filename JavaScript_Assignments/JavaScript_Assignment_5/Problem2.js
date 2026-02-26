class BankAccount {

    constructor(accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposit(amount) {
        this.balance += amount;
        console.log(`₹${amount} deposited successfully.`);
        this.checkBalance();
    }

    withdraw(amount) {
        if (amount > this.balance) {
            console.log("Insufficient balance. Withdrawal denied.");
        } else {
            this.balance -= amount;
            console.log(`₹${amount} withdrawn successfully.`);
            this.checkBalance();
        }
    }

    checkBalance() {
        console.log(`Current Balance: ₹${this.balance}`);
    }

}

let acc1 = new BankAccount("Kavya", 5000);

acc1.checkBalance();
acc1.deposit(2000);
acc1.withdraw(3000);
acc1.withdraw(6000);
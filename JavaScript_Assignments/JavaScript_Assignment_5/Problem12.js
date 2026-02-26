class Wallet {

    #balance;

    constructor(initialAmount = 0) {
        this.#balance = initialAmount;
    }

    addMoney(amount) {
        if (amount > 0) {
            this.#balance += amount;
            console.log(`₹${amount} added.`);
        } else {
            console.log("Invalid amount.");
        }
    }

    spendMoney(amount) {
        if (amount > this.#balance) {
            console.log("Insufficient balance.");
        } else if (amount > 0) {
            this.#balance -= amount;
            console.log(`₹${amount} spent.`);
        } else {
            console.log("Invalid amount.");
        }
    }

    getBalance() {
        return this.#balance;
    }

}

let myWallet = new Wallet(1000);

myWallet.addMoney(500);
myWallet.spendMoney(300);

console.log("Current Balance:", myWallet.getBalance());

console.log(myWallet.balance);
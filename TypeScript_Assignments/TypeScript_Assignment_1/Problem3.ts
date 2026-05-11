class BankAccount {

    // Properties
    depositorName: string;
    accountNumber: number;
    accountType: string;
    balanceAmount: number;

    // Constructor
    constructor(
        depositorName: string,
        accountNumber: number,
        accountType: string,
        balanceAmount: number
    ) {
        this.depositorName = depositorName;
        this.accountNumber = accountNumber;
        this.accountType = accountType;
        this.balanceAmount = balanceAmount;
    }

    // Deposit Method
    deposit(amount: number): void {
        this.balanceAmount += amount;
        console.log("Deposited Amount: " + amount);
    }

    // Withdraw Method
    withdraw(amount: number): void {

        if (amount <= this.balanceAmount) {
            this.balanceAmount -= amount;
            console.log("Withdrawn Amount: " + amount);
        }
        else {
            console.log("Insufficient Balance");
        }
    }

    // Display Method
    display(): void {
        console.log("Depositor Name: " + this.depositorName);
        console.log("Balance Amount: " + this.balanceAmount);
    }
}

// Creating Object
let account1 = new BankAccount(
    "Kavya",
    1001,
    "Savings",
    5000
);

// Display Initial Details
account1.display();

// Deposit Amount
account1.deposit(2000);

// Withdraw Amount
account1.withdraw(3000);

// Display Final Balance
account1.display();
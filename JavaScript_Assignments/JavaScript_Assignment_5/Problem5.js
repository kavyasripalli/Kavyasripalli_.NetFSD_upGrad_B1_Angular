class Employee {

    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        console.log(`Name: ${this.name}`);
        console.log(`Base Salary: ₹${this.salary}`);
    }

}

class Manager extends Employee {

    constructor(name, salary, bonus) {
        super(name, salary);
        this.bonus = bonus;
    }

    getTotalSalary() {
        let total = this.salary + this.bonus;
        console.log(`Total Salary (with Bonus): ₹${total}`);
        return total;
    }

}

class Director extends Manager {

    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        let fullComp = this.salary + this.bonus + this.stockOptions;
        console.log(`Full Compensation (Salary + Bonus + Stock): ₹${fullComp}`);
        return fullComp;
    }

}

let director1 = new Director("Kavya", 100000, 20000, 50000);

director1.getDetails();
director1.getTotalSalary();
director1.getFullCompensation();
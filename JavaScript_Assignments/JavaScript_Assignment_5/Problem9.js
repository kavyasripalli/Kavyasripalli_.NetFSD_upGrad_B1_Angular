class Product {

    constructor({ name, price, category = "General" }) {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    getDetails = () => {
        console.log(`Product: ${this.name} | Price: ₹${this.price} | Category: ${this.category}`);
    }

    applyDiscount = (discountPercent = 10) => {
        let discountedPrice = this.price - (this.price * discountPercent / 100);
        console.log(`Price after ${discountPercent}% discount: ₹${discountedPrice}`);
        return discountedPrice;
    }

}

let productData = {
    name: "Laptop",
    price: 60000
};

let p1 = new Product({ ...productData });

p1.getDetails();
p1.applyDiscount();
p1.applyDiscount(20);
let cart = [
    { id: 1, product: "Laptop", price: 60000, qty: 1 },
    { id: 2, product: "Headphones", price: 2000, qty: 2 },
    { id: 3, product: "Mouse", price: 800, qty: 1 }
];

let totalValue = cart.reduce((total, item) => {
    return total + (item.price * item.qty);
}, 0);
console.log("Total Cart Value:", totalValue);

let updatedCart = cart.map(item => {
    if (item.id === 3) {
        return { ...item, qty: item.qty + 1 };
    }
    return item;
});
console.log("After Increasing Quantity:", updatedCart);

let cartAfterRemoval = cart.filter(item => item.id !== 2);
console.log("After Removing Product ID 2:", cartAfterRemoval);

let discountedCart = cart.map(item => {
    if (item.price > 10000) {
        return { ...item, price: item.price * 0.9 };
    }
    return item;
});
console.log("After 10% Discount:", discountedCart);

let sortedCart = [...cart].sort((a, b) => {
    return (b.price * b.qty) - (a.price * a.qty);
});
console.log("Sorted by Total Item Price:", sortedCart);

let expensiveProductExists = cart.some(item => item.price > 50000);
console.log("Any product above 50000:", expensiveProductExists);

let allInStock = cart.every(item => item.qty > 0);
console.log("All items in stock:", allInStock);

let invoice = cart.map(item => {
    return item.product + " x " + item.qty + " = " + (item.price * item.qty);
}).join(" | ");
console.log("Invoice:", invoice);

let mostExpensive = cart.reduce((max, item) => {
    return item.price > max.price ? item : max;
});
console.log("Most Expensive Product:", mostExpensive);

let gst = totalValue * 0.18;
let totalWithGST = totalValue + gst;
console.log("GST (18%):", gst);
console.log("Total with GST:", totalWithGST);
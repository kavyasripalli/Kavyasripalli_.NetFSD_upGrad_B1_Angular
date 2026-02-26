let books = [
    { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
    { id: 2, title: "React Guide", price: 650, stock: 5 },
    { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
    { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

let titles = books.map(book => book.title);
console.log("All Book Titles:", titles);

let totalValue = books.reduce((total, book) => {
    return total + (book.price * book.stock);
}, 0);
console.log("Total Inventory Value:", totalValue);

let costlyBooks = books.filter(book => book.price > 500);
console.log("Books above 500:", costlyBooks);

let increasedPriceBooks = books.map(book => {
    return {
        ...book,
        price: book.price * 1.05
    };
});
console.log("Price increased by 5%:", increasedPriceBooks);

let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log("Sorted by price:", sortedBooks);

let updatedBooks = books.filter(book => book.id !== 2);
console.log("After removing ID 2:", updatedBooks);

let isOutOfStock = books.some(book => book.stock === 0);
console.log("Any book out of stock:", isOutOfStock);

let groupedBooks = books.reduce((group, book) => {
    if (book.price <= 400) {
        group.low.push(book);
    } else if (book.price <= 600) {
        group.medium.push(book);
    } else {
        group.high.push(book);
    }
    return group;
}, { low: [], medium: [], high: [] });

console.log("Grouped by price range:", groupedBooks);

let discountedBooks = books.map(book => {
    if (book.price > 600) {
        return { ...book, price: book.price * 0.9 };
    }
    return book;
});
console.log("Discount applied:", discountedBooks);

let invoice = books.map(book => book.title).join(", ");
console.log("Invoice string:", invoice);
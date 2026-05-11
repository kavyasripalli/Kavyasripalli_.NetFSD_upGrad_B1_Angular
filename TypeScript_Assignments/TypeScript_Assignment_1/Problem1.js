"use strict";
class BookStore {
    // Properties
    isbn;
    bookName;
    bookTitle;
    bookAuthor;
    quantityOfBooks;
    bookPrice;
    // Constructor
    constructor(isbn, bookName, bookTitle, bookAuthor, quantityOfBooks, bookPrice) {
        this.isbn = isbn;
        this.bookName = bookName;
        this.bookTitle = bookTitle;
        this.bookAuthor = bookAuthor;
        this.quantityOfBooks = quantityOfBooks;
        this.bookPrice = bookPrice;
    }
    // Method to display book details
    displayBookDetails() {
        console.log("ISBN: " + this.isbn);
        console.log("Book Name: " + this.bookName);
        console.log("Book Title: " + this.bookTitle);
        console.log("Book Author: " + this.bookAuthor);
        console.log("Quantity of Books: " + this.quantityOfBooks);
        console.log("Book Price: " + this.bookPrice);
    }
    // Method to calculate bill amount
    calculateBill() {
        return this.quantityOfBooks * this.bookPrice;
    }
}
// Creating Object
let book1 = new BookStore(101, "TypeScript Basics", "Learning TypeScript", "James", 5, 500);
// Calling Methods
book1.displayBookDetails();
console.log("Total Bill Amount: " + book1.calculateBill());

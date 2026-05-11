class BookStore {
    
    // Properties
    isbn: number;
    bookName: string;
    bookTitle: string;
    bookAuthor: string;
    quantityOfBooks: number;
    bookPrice: number;

    // Constructor
    constructor(
        isbn: number,
        bookName: string,
        bookTitle: string,
        bookAuthor: string,
        quantityOfBooks: number,
        bookPrice: number
    ) {
        this.isbn = isbn;
        this.bookName = bookName;
        this.bookTitle = bookTitle;
        this.bookAuthor = bookAuthor;
        this.quantityOfBooks = quantityOfBooks;
        this.bookPrice = bookPrice;
    }

    // Method to display book details
    displayBookDetails(): void {
        console.log("ISBN: " + this.isbn);
        console.log("Book Name: " + this.bookName);
        console.log("Book Title: " + this.bookTitle);
        console.log("Book Author: " + this.bookAuthor);
        console.log("Quantity of Books: " + this.quantityOfBooks);
        console.log("Book Price: " + this.bookPrice);
    }

    // Method to calculate bill amount
    calculateBill(): number {
        return this.quantityOfBooks * this.bookPrice;
    }
}

// Creating Object
let book1 = new BookStore(
    101,
    "TypeScript Basics",
    "Learning TypeScript",
    "James",
    5,
    500
);

// Calling Methods
book1.displayBookDetails();

console.log("Total Bill Amount: " + book1.calculateBill());
class Student {

    // Properties
    rollNo: number;
    studName: string;
    marksInEng: number;
    marksInMaths: number;
    marksInScience: number;

    // Constructor
    constructor(
        rollNo: number,
        studName: string,
        marksInEng: number,
        marksInMaths: number,
        marksInScience: number
    ) {
        this.rollNo = rollNo;
        this.studName = studName;
        this.marksInEng = marksInEng;
        this.marksInMaths = marksInMaths;
        this.marksInScience = marksInScience;
    }

    // Method to calculate total
    calculateTotal(): number {
        return this.marksInEng +
               this.marksInMaths +
               this.marksInScience;
    }

    // Method to calculate percentage
    calculatePercentage(): number {
        return (this.calculateTotal() / 300) * 100;
    }

    // Display Method
    display(): void {

        console.log("Roll Number: " + this.rollNo);
        console.log("Student Name: " + this.studName);

        console.log("English Marks: " + this.marksInEng);
        console.log("Maths Marks: " + this.marksInMaths);
        console.log("Science Marks: " + this.marksInScience);

        console.log("Total Marks: " + this.calculateTotal());

        console.log(
            "Percentage: " +
            this.calculatePercentage().toFixed(2) + "%"
        );
    }
}

// Creating Object
let student1 = new Student(
    101,
    "Kavya",
    85,
    90,
    95
);

// Calling Display Method
student1.display();
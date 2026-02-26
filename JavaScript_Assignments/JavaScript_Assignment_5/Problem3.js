class Student {

    constructor(name) {
        this.name = name;
        this.marks = [];
    }

    addMark(mark) {
        this.marks.push(mark);
        console.log(`Mark ${mark} added.`);
    }

    getAverage() {
        if (this.marks.length === 0) {
            return 0;
        }

        let total = this.marks.reduce((sum, mark) => sum + mark, 0);
        return total / this.marks.length;
    }

    getGrade() {
        let average = this.getAverage();

        if (average >= 90) {
            return "A";
        } else if (average >= 75) {
            return "B";
        } else if (average >= 50) {
            return "C";
        } else {
            return "Fail";
        }
    }

}

let s1 = new Student("Kavya");

s1.addMark(85);
s1.addMark(92);
s1.addMark(78);

console.log("Average:", s1.getAverage());
console.log("Grade:", s1.getGrade());
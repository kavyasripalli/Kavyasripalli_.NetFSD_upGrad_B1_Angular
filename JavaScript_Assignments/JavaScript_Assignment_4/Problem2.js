let students = [
    { name: "Kavya", marks: 85 },
    { name: "Priya", marks: 72 },
    { name: "Sri", marks: 90 },
    { name: "Harika", marks: 45 },
    { name: "Kavya sri", marks: 30 }
];

let passedStudents = students.filter(student => student.marks >= 40);
console.log("Passed Students:", passedStudents);

let distinctionStudents = students.filter(student => student.marks >= 85);
console.log("Distinction Students:", distinctionStudents);

let averageMarks = students.reduce((total, student) => total + student.marks, 0) / students.length;
console.log("Class Average:", averageMarks);

let topper = students.reduce((max, student) => student.marks > max.marks ? student : max);
console.log("Topper:", topper);

let failedCount = students.filter(student => student.marks < 40).length;
console.log("Failed Students Count:", failedCount);

let studentsWithGrades = students.map(student => {
    let grade;
    if (student.marks >= 85) {
        grade = "A";
    } else if (student.marks >= 60) {
        grade = "B";
    } else if (student.marks >= 40) {
        grade = "C";
    } else {
        grade = "Fail";
    }
    return { ...student, grade: grade };
});
console.log("Students with Grades:", studentsWithGrades);

let leaderboard = [...students].sort((a, b) => b.marks - a.marks);
let rankedStudents = leaderboard.map((student, index) => {
    return { ...student, rank: index + 1 };
});
console.log("Leaderboard with Rank:", rankedStudents);

let withoutLowest = leaderboard.slice(0, leaderboard.length - 1);
console.log("After Removing Lowest Scorer:", withoutLowest);
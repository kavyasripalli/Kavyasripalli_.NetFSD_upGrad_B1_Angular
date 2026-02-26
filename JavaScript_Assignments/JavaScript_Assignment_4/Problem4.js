let employees = [
    { id:1, name:"Kavya", dept:"IT", salary:70000 },
    { id:2, name:"Sri", dept:"HR", salary:50000 },
    { id:3, name:"Kavya Sri", dept:"IT", salary:80000 },
    { id:4, name:"Harika", dept:"Finance", salary:60000 }
];

let totalSalary = employees.reduce((total, emp) => total + emp.salary, 0);
console.log("Total Salary Expense:", totalSalary);

let highestPaid = employees.reduce((max, emp) => emp.salary > max.salary ? emp : max);
let lowestPaid = employees.reduce((min, emp) => emp.salary < min.salary ? emp : min);
console.log("Highest Paid:", highestPaid);
console.log("Lowest Paid:", lowestPaid);

let increasedITSalary = employees.map(emp => {
    if (emp.dept === "IT") {
        return { ...emp, salary: emp.salary * 1.15 };
    }
    return emp;
});
console.log("IT Salary Increased by 15%:", increasedITSalary);

let groupedByDept = employees.reduce((group, emp) => {
    if (!group[emp.dept]) {
        group[emp.dept] = [];
    }
    group[emp.dept].push(emp);
    return group;
}, {});
console.log("Grouped by Department:", groupedByDept);

let deptAverage = employees.reduce((acc, emp) => {
    if (!acc[emp.dept]) {
        acc[emp.dept] = { total: 0, count: 0 };
    }
    acc[emp.dept].total += emp.salary;
    acc[emp.dept].count += 1;
    return acc;
}, {});

for (let dept in deptAverage) {
    deptAverage[dept] = deptAverage[dept].total / deptAverage[dept].count;
}
console.log("Department-wise Average Salary:", deptAverage);

let sortedBySalary = [...employees].sort((a, b) => b.salary - a.salary);
console.log("Sorted by Salary Descending:", sortedBySalary);

let afterTax = employees.map(emp => {
    return { ...emp, salaryAfterTax: emp.salary * 0.9 };
});
console.log("After 10% Tax Deduction:", afterTax);

let averageSalary = totalSalary / employees.length;
let aboveAverage = employees.filter(emp => emp.salary > averageSalary);
console.log("Employees Above Average Salary:", aboveAverage);

let tableHTML = "<table border='1'><tr><th>ID</th><th>Name</th><th>Dept</th><th>Salary</th></tr>";

employees.forEach(emp => {
    tableHTML += "<tr>" +
                 "<td>" + emp.id + "</td>" +
                 "<td>" + emp.name + "</td>" +
                 "<td>" + emp.dept + "</td>" +
                 "<td>" + emp.salary + "</td>" +
                 "</tr>";
});

tableHTML += "</table>";

document.getElementById("employeeTable").innerHTML = tableHTML;
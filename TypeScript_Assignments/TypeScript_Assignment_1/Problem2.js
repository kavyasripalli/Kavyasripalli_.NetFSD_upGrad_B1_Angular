"use strict";
class Shapes {
    // Method Implementation
    Area(a, b, c) {
        // Circle
        if (b === undefined && c === undefined) {
            return 3.14 * a * a;
        }
        // Triangle
        else if (c === "triangle") {
            return 0.5 * a * b;
        }
        // Rectangle
        else {
            return a * b;
        }
    }
    // Separate method for Square
    squareArea(side) {
        return side * side;
    }
}
// Creating Object
let shape = new Shapes();
// Rectangle
console.log("Area of Rectangle: " + shape.Area(10, 5));
// Triangle
console.log("Area of Triangle: " + shape.Area(10, 5, "triangle"));
// Circle
console.log("Area of Circle: " + shape.Area(7));
// Square
console.log("Area of Square: " + shape.squareArea(4));

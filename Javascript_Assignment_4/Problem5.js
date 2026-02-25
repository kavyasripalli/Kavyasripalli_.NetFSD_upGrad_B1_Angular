let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let uniqueNumbers = [...new Set(numbers)];
console.log("Remove Duplicates:", uniqueNumbers);

let sortedDesc = [...uniqueNumbers].sort((a, b) => b - a);
let secondLargest = sortedDesc[1];
console.log("Second Largest Number:", secondLargest);

let frequency = numbers.reduce((acc, num) => {
    acc[num] = (acc[num] || 0) + 1;
    return acc;
}, {});
console.log("Frequency of Each Element:", frequency);

let firstNonRepeating = numbers.find(num => frequency[num] === 1);
console.log("First Non-Repeating Number:", firstNonRepeating);

let rotatedArray = [...numbers.slice(2), ...numbers.slice(0, 2)];
console.log("Array Rotated by 2 Positions:", rotatedArray);

let nestedArray = [1, 2, [3, 4, [5]]];

function flattenArray(arr) {
    return arr.reduce((flat, item) => {
        return flat.concat(Array.isArray(item) ? flattenArray(item) : item);
    }, []);
}

let flattened = flattenArray(nestedArray);
console.log("Flattened Array:", flattened);

let missingArray = [1, 2, 3, 5, 6];

let missingNumber = null;
for (let i = 1; i <= missingArray.length + 1; i++) {
    if (!missingArray.includes(i)) {
        missingNumber = i;
        break;
    }
}

console.log("Missing Number:", missingNumber);
console.log("Hello,");

let name1 = 'Ørjan Torque', name2 = 'Marcus Worque'; // Let is better to use then var

console.log(name1, 'and' ,name2);

let age1 = 34, age2 = 21; // Lets are variables, and can be changed

const maxAge = 100; // Constants cant be changed

let above20 = true; // Bollean

let undef = undefined; // Makes it so the variable is undefined
let nothing = null; // Null makes the variable empty


let students = {
    student1: 'Elias',
    student2: 'Marcus'
}; // This creates a "object" that can contain multile variables of the type let

console.log('Our manager is known as', students.student1); // Works like classes in cpp

students['student1'] = students.student1; // To måter å calle på det samme

let neighbourGroup = ['Gruppe1', 'Gruppe2'];

console.log('Our neighbouring group is', neighbourGroup[0]); // Printer ut første indeksering

function print() {
    console.log('Printeren er skrudd på.');
}

print(); // calls on function like in cpp

const externalData = require('./extras'); // Calls in the variables stored in "Module.exports" in the extras code
console.log(externalData.name); // Prints whole item/class from the other code, called extras in this case.

const os = require('os'); // Can import other data as well, in this case info regarding our operating system
console.log(os.homedir);


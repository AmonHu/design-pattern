import {Singleton} from "./singleton/singleton.js";

let s = new Singleton();
console.log(s.name);

let s2 = new Singleton();
s2.name = '123';
console.log(s2.name);
console.log(s.name);

console.log(s === s2);


let myElement = document.getElementById("one");

console.log(myElement);
let pineNuts = document.getElementById("two");
//pineNuts.setAttribute("class", "nuts, hot");
let honey = document.getElementById("three");
honey.setAttribute("hidden","true");
// task 2
let list = Array.from(document.getElementsByClassName("hot"));
for (let index = 0; index < list.length; index++) 
{
    element = list[index];
    element.setAttribute("class", "cool");
    console.log(element);
}
//task 3

let sceneList = document.getElementById("firstul");
let newElement = document.createElement("li");
newElement.setAttribute("id", "four");
newElement.setAttribute("class", "hot");
let textNode = document.createTextNode("Coffee");
newElement.appendChild(textNode);
sceneList.appendChild(newElement);


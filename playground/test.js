const add = (x) => x + 1;
const parseString = (x) => `${x}`;
const composes = () => (z = parseInt(document.getElementById('h1').innerText)) => document.getElementById('h1').innerText = parseString(add(z));
const fuck = () => {
    console.log("stupid alex");
}

const btn = document.getElementById('btn');
btn.addEventListener("click", () => composes()());
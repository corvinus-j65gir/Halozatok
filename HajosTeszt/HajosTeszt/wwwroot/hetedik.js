window.onload = (Letöltés)
var kérdések = {}

function Letöltés() {
    fetch('questions.json')
        .then(r => r.json())
        .then(d => LetöltésBefejeződött(d));
}


function LetöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    kérdés = d;
    kérdésMegjelenítés(0);
}

function kérdésMegjelenítés(k) {
    let ide_kérdés = document.getElementById("kérdés_szöveg")
    ide_kérdés.innerHTML = kérdés[k].questionText;
    console.log('$ {kérdés.length} kérdés érkezett}')

    for (var i = 1; i <= 3; i++) {
        let elem_kérdés = document.getElementById("válasz" + i)
        elem_kérdés.innerText = kérdés[k]["answer" + i]
    }

    document.getElementById("kép1").src = "https://szoft1.comeback.hu/hajo/" + kérdés[k].image
}

function click(c) {
    let ide_vissza = document.getElementById("gomb vissza")
    ide_vissza.innerHTML = kérdésMegjelenítés(i-1)
}
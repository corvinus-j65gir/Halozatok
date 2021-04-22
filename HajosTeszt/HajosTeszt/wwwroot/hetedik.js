function kérdésBetöltés(id) {
    fetch('/questions/${id}')
        .then(válaszfeldolgozás)
        .then(kérdékérdésMegjelenítés);
}

function válaszfeldolgozás(válasz) {
    if (!válasz.ok) {
        console.error('Hibás válasz: ${response.status}')
    }
    else {
        return válasz.json()
    }
}


function kérdésMegjelenítés(kérdés) {
    console.log(kérdés);
    document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
    document.getElementById("válasz1").innerText = kérdés.answer1
    document.getElementById("válasz2").innerText = kérdés.answer2
    document.getElementById("válasz3").innerText = kérdés.answer3
    document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image; 
}

function click(c) {
    let ide_vissza = document.getElementById("gomb vissza")
    ide_vissza.innerHTML = kérdésMegjelenítés(i-1)
}
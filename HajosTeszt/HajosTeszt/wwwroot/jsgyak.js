var faktoriálisR = (n) => {
    if (n === 0 || n === 1) {
        return 1;
    } else {
        return n * faktoriálisR(n - 1)
    }
    
}



window.onload = function () {
    console.log("start")

    let hova = document.getElementById("pascal");
    for (var s = 0; s < 10; s++) {
        let sor = document.createElement("div");
        sor.classList.add("sor")
        hova.appendChild(sor);

        for (var o = 0; o < 10; o++) {
            let szám = document.createElement("div");
            szám.classList.add("elem")
            szám.innerHTML = `${faktoriálisR(s)}`
            sor.appendChild(szám);
        }
    }
}
// **  (*) als commentaar die ni weg mag:   180201 https://www.w3schools.com/js/tryit.asp?filename=tryjs_timing_clock

function startTime() {
    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var s = today.getSeconds();
    m = checkTime(m);
    s = checkTime(s);
    document.getElementById('txt').innerHTML =
        h + ":" + m + ":" + s;
    var t = setTimeout(startTime, 500);
}

function checkTime(i) {
    if (i < 10) { i = "0" + i };  // add zero in front of numbers < 10
    return i;
}

function telOp() {
    var getal01 = parseInt(document.getElementById("txtGetal01").value);
    var getal02 = parseInt(document.getElementById("txtGetal02").value);
    var resultaat = getal01 + getal02;

    if (isNaN(resultaat)) {
        resultaat = "Gelieve enkel getallen in te vullen.";
    }

    document.getElementById("divResultaat").innerHTML = "" + resultaat;
}

function randomContent() {
    var random = Math.floor((Math.random() * 5) + 1);

    switch (random) {
        case 1:
            document.getElementById("divRandomContent").innerHTML = document.getElementById("txtRNG01").value;
            break;
        case 2:
            document.getElementById("divRandomContent").innerHTML = document.getElementById("txtRNG02").value;
            break;
        case 3:
            document.getElementById("divRandomContent").innerHTML = document.getElementById("txtRNG03").value;
            break;
        case 4:
            document.getElementById("divRandomContent").innerHTML = document.getElementById("txtRNG04").value;
            break;
        case 5:
            document.getElementById("divRandomContent").innerHTML = document.getElementById("txtRNG05").value;
            break;
        default:
            document.getElementById("divRandomContent").innerHTML = "Oops! RNG incorrect";
            break;
    }
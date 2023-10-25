
var valorElemento = "";
var valorOperacion = "";

function capturarSeleccion() {
    //Obtengo el elemento
    var elementoSeleccionado = document.getElementById("opc-sexo");
    //Posibles valores del elemento (Si/No)
    valorElemento = elementoSeleccionado.value;
    //Obtengo el elemento
    var operacionSeleccionada = document.getElementById("opc-operacion");
    //Posibles valores del elemento (Intervalo/=/>/</>=/<=)
    valorOperacion = operacionSeleccionada.value;
    if (valorElemento === "Si" && valorOperacion != "Intervalo") {
        document.getElementById("vr-doble-m").hidden = false;
        document.getElementById("vr-doble-h").hidden = false;
        document.getElementById("vr-unico").hidden = true;
        document.getElementById("vr-unico-int-ini").hidden = true;
        document.getElementById("vr-unico-int-fin").hidden = true;
        document.getElementById("vr-doble-m-int-ini").hidden = true;
        document.getElementById("vr-doble-m-int-fin").hidden = true;
        document.getElementById("vr-doble-h-int-ini").hidden = true;
        document.getElementById("vr-doble-h-int-fin").hidden = true;
    } else if (valorElemento === "No" && valorOperacion != "Intervalo") {
        document.getElementById("vr-doble-m").hidden = true;
        document.getElementById("vr-doble-h").hidden = true;
        document.getElementById("vr-unico").hidden = false;
        document.getElementById("vr-unico-int-ini").hidden = true;
        document.getElementById("vr-unico-int-fin").hidden = true;
        document.getElementById("vr-doble-m-int-ini").hidden = true;
        document.getElementById("vr-doble-m-int-fin").hidden = true;
        document.getElementById("vr-doble-h-int-ini").hidden = true;
        document.getElementById("vr-doble-h-int-fin").hidden = true;
    } else if (valorElemento === "Si" && valorOperacion === "Intervalo") {
        document.getElementById("vr-doble-m").hidden = true;
        document.getElementById("vr-doble-h").hidden = true;
        document.getElementById("vr-unico").hidden = true;
        document.getElementById("vr-unico-int-ini").hidden = true;
        document.getElementById("vr-unico-int-fin").hidden = true;
        document.getElementById("vr-doble-m-int-ini").hidden = false;
        document.getElementById("vr-doble-m-int-fin").hidden = false;
        document.getElementById("vr-doble-h-int-ini").hidden = false;
        document.getElementById("vr-doble-h-int-fin").hidden = false;
    } else if (valorElemento === "No" && valorOperacion === "Intervalo"){
        document.getElementById("vr-doble-m").hidden = true;
        document.getElementById("vr-doble-h").hidden = true;
        document.getElementById("vr-unico").hidden = true;
        document.getElementById("vr-unico-int-ini").hidden = false;
        document.getElementById("vr-unico-int-fin").hidden = false;
        document.getElementById("vr-doble-m-int-ini").hidden = true;
        document.getElementById("vr-doble-m-int-fin").hidden = true;
        document.getElementById("vr-doble-h-int-ini").hidden = true;
        document.getElementById("vr-doble-h-int-fin").hidden = true;
    }
}


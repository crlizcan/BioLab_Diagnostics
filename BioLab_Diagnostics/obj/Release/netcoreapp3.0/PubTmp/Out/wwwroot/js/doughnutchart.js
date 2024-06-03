
var ctxD = document.getElementById("doughnutChart").getContext('2d');
var myLineChart = new Chart(ctxD, {
    type: 'doughnut',
    data: {
        labels: nombresPruebasMasSolicitadas,
        datasets: [{
            data: cantPruebasMasSolicitadas,
            backgroundColor: ["#1F2328", "#CED2D7", "#8393AB", "#314b73", "#3e5f8a"],
            hoverBackgroundColor: ["#0F1316", "#BEC3C8", "#6D7E98", "#1E2D4B", "#2A4161"]
        }]
    },
    options: {
        responsive: true
    }
});
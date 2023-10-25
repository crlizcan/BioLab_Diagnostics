// Configuro el contexto del gráfico
var ctxL = document.getElementById("lineChart").getContext('2d');

// Creo el gráfico de líneas
var myLineChart = new Chart(ctxL, {
    type: 'line',
    data: {
        labels: ultimos12Meses,
        datasets: [{
            label: "Peticiones mensuales",
            data: peticionesSolicitadas,
            backgroundColor: '#053c76',
            borderColor: '#053c76',
            borderWidth: 2,
            pointRadius: 0,
            pointHoverRadius: 5,
            steppedLine: true,
            yAxisID: 'y'
        },
        {
            label: "Beneficios mensuales",
            data: beneficios,
            backgroundColor: '#6d8fba',
            borderColor: '#6d8fba',
            borderWidth: 2,
            pointRadius: 0,
            pointHoverRadius: 5,
            steppedLine: true,
            yAxisID: 'y1'
        }]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        scales: {
            x: {
                beginAtZero: true,
                grid: {
                    display: false
                }
            },
            y: {
                beginAtZero: true,
                grid: {
                    display: false
                }
            },
            y1: {
                position: 'right',
                beginAtZero: true,
                grid: {
                    display: false
                }
            }
        },
        plugins: {
            tooltip: {
                mode: 'index', 
                intersect: false
            }
        }
    }
});

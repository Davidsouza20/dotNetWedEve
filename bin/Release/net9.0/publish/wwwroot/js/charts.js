window.renderChart = function (canvasId, chartType, chartData) {
    const ctx = document.getElementById(canvasId).getContext('2d');

    // Only destroy if it exists and is a Chart instance
    if (window[canvasId] instanceof Chart) {
        window[canvasId].destroy();
    }

    window[canvasId] = new Chart(ctx, {
        type: chartType,
        data: chartData,
        options: {
            responsive: true,
            maintainAspectRatio: false
        }
    });
};
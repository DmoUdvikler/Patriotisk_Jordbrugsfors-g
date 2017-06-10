$(document).ready(function () {
    $(".forGraph").click(function () {
        var text = $(this).text().replace("experiment", "").trim();  
        getExperimentForGraph(text);
    });
});
function getExperimentForGraph(number) {
    $.ajax({
        type: "GET",
        url: "/api/Experiment/Graph/",
        data: "id= " + number,
        success: function (data) {
            if (data !== null)
                createGraph(data); 
        }
    });

}
function createGraph(numberArray) {
    var canvasHeight = 500;
    var canvasWidth = 600;
    var c = document.getElementById("graphCanvasID");
    var context = c.getContext("2d");
    context.clearRect(0, 0, canvasWidth, canvasHeight);
    var segmentHeight;
    var margin = 4;
    var numberOfSegments = numberArray.length;
    
    var segmentWidth = (canvasWidth / numberOfSegments) - (margin * 2);
    var ratio;
    var highestNumber = 0;
    var maxHeightOfSegment = canvasHeight - 40;

    for (i = 0; i < numberOfSegments; i++) {
        if (numberArray[i][0] > highestNumber)
            highestNumber = numberArray[i][0];
    }
    for (i = 0; i < numberOfSegments; i++) {
        ratio = numberArray[i][0] / highestNumber;
        segmentHeight = ratio * maxHeightOfSegment;
        context.fillStyle = "#47d147";
        context.textAlign = "center";
        context.fillRect(margin + ((i * canvasWidth) / numberOfSegments), canvasHeight - segmentHeight, segmentWidth, segmentHeight);
        context.fillStyle = "#000000";
        context.font = "12px Arial";
        context.fillText(numberArray[i][0].toString(), (i * canvasWidth / numberOfSegments) + ((canvasWidth / numberOfSegments) / 2), canvasHeight - segmentHeight - 10);
        context.font = "12px Arial";
        context.fillText(numberArray[i][1].toString(), (i * canvasWidth / numberOfSegments) + ((canvasWidth / numberOfSegments) / 2), canvasHeight - 1);
    }
}
function setupTable() {
    var rows = parseInt(document.getElementById("rows").value);
    var columns = parseInt(document.getElementById("columns").value);

    var tableDiv = document.getElementById("dynamicTable");

    var dynamicTable = document.createElement("TABLE");
    dynamicTable.setAttribute("contenteditable", "true"); 
    dynamicTable.border = "1";

    var dynamicTableBody = document.createElement("TBODY");
    dynamicTable.appendChild(dynamicTableBody);

    for (var i = 0; i < rows; i++) {
        var tableRow = document.createElement("TR");

        dynamicTableBody.appendChild(tableRow);

        for (var j = 0; j < columns; j++) {
            var tableColumn = document.createElement("TD");
            tableColumn.width = "100";
            tableColumn.appendChild(document.createTextNode(""));
            tableRow.appendChild(tableColumn);
        }
    }
    tableDiv.appendChild(dynamicTable);

}
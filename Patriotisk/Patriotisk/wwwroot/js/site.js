﻿$(document).ready(function () {
    createGraph();
});
function createGraph(/*numberArray*/) {
    var numberArray = [[3347, "Ubehandlet 40 pl"], [3322, "Ubehandlet 40 pl"],
    [3442, "1,5 l Folicur Xpert 40 pl"], [3488, "1,5 l Folicur Xpert 20 pl"]];
    // var numberArray = [ [2,"Caryx"],[4,"Folicur Xpert"]]; 
    var c = document.getElementById("graphCanvasID");
    var context = c.getContext("2d");
    var segmentHeight;
    var margin = 4;
    var numberOfSegments = numberArray.length;
    var canvasHeight = 500;
    var canvasWidth = 600;
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

    var table = document.createElement("TABLE");
    table.setAttribute("contenteditable", "true"); 
    table.border = "1";

    var tableBody = document.createElement("TBODY");
    table.appendChild(tableBody);

    for (var i = 0; i < rows; i++) {
        var tableRow = document.createElement("TR");

        tableBody.appendChild(tableRow);

        for (var j = 0; j < columns; j++) {
            var tableColumn = document.createElement("TD");
            tableColumn.width = "100";
            tableColumn.appendChild(document.createTextNode(""));
            tableRow.appendChild(tableColumn);
        }
    }
    tableDiv.appendChild(table);

}
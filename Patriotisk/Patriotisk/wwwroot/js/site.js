$(document).ready(function () {
  
});

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
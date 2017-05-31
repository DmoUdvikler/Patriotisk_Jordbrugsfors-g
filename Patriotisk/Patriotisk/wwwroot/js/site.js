$(document).ready(function () {
    //$("#createTable").click(function () {
    //    setupTable(); 
    //});
});

function setupTable() {
    var rows = parseInt(document.getElementById("rows").value);
    var columns = parseInt(document.getElementById("columns").value); 

    var myTableDiv = document.getElementById("dynamicTable");

    var table = document.createElement("TABLE");
    table.border = '1';

    var tableBody = document.createElement("TBODY");
    table.appendChild(tableBody);

    for (var i = 0; i < rows; i++) {
        var tr = document.createElement("TR");
        tableBody.appendChild(tr);

        for (var j = 0; j < columns; j++) {
            var td = document.createElement("TD").contentEditable;
            td.width = "100";
            td.appendChild(document.createTextNode("Cell " + i + "," + j));
            tr.appendChild(td);
        }
    }
    myTableDiv.appendChild(table);

}
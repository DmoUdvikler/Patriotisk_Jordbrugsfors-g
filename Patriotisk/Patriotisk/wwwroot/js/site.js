$(document).ready(function () {
    $("#submitExperiement").click(function () {
        submitExperiment();
    });
});
function submitExperiment() {
    //$.post("api/Home/CreateExperiment/Post", $("#createForm").serialize(), function (data) {
    //do whatever with the response
    var dataToPost = $("#MyForm").serialize(); 
    $.ajax({
        type: "Post",
        url: "api/Home/CreateExperiment",
        data: JSON.stringify(dataToPost),
        contentType: 'application/json; charset=utf-8'
    });
}
    //$("#createForm").ajaxForm({ url: 'api/Home/CreateExperiment', type: 'post' })
    //$.post('api/Home/CreateExperiment', $('#createForm').serialize())

    //var $file = document.getElementById('file'),
    //$formData = new FormData();

    //if ($file.files.length > 0) {
    //    for (var i = 0; i < $file.files.length; i++) {
    //        $formData.append('file-' + i, $file.files[i]);
    //    }
    //}

    //$.ajax({
    //    url: 'api/Home/CreateExperiment',
    //    type: 'POST',
    //    data: $formData,
    //    dataType: 'json',
    //    contentType: false,
    //    processData: false,
    //    success: function ($data) {

    //    }
    //});




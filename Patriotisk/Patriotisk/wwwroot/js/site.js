$(document).ready(function () {
    $("#submitExperiement").click(function () {
        submitExperiment();
    });
});
function submitExperiment() {
  
   
        var formData = new FormData();
        var uploadedFile = document.getElementById("file").files[0];
        formData.append(uploadedFile.name, uploadedFile);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", '@/api/Home/CreateExperiment/.Action("FileUpload", "Content")', true);
        xhr.send(formData);
     //$.ajax({
        //var data;
        //data = new FormData();
        //data.append('file', $('#file')[0].files[0]);
        ////url: "/api/Home/CreateExperiment/", 
        //data: data,
        //processData: false,
        //type: 'POST',

        //// This will override the content type header, 
        //// regardless of whether content is actually sent.
        //// Defaults to 'application/x-www-form-urlencoded'
        //contentType: 'multipart/form-data',

        ////Before 1.5.1 you had to do this:
        //beforeSend: function (x) {
        //    if (x && x.overrideMimeType) {
        //        x.overrideMimeType("multipart/form-data");
        //    }
        //},
        //// Now you should be able to do this:
        //mimeType: 'multipart/form-data',    //Property added in 1.5.1

        //success: function (data) {
        //    alert(data);
        //}
    //});

    e.preventDefault();
}

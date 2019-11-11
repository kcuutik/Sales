

GetAll();
function GetAll() {
    $.ajax({
        type: "GET",
        url: "/AdminImge/GetAll",
        dataType: "html",
        success: function (response) {
            $('#listImage').html(response);
            $('#listImage').show();
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });
}

$(document).on('click', '#btnAddtImage', function () {
    $('#listImage').hide();
    $('#typography').show();
    $.ajax({
        type: "GET",
        url: "/AdminImge/FormInsert",
        dataType: "html",
        success: function (response) {
            $('#typography').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });

});

$(document).on('click', '#btnListImage', function () {
    $('#listImage').show();
    $('#typography').hide();
    GetAll();
}); 

$(document).on('click', '[name=btnSave]', function () {
    if (window.FormData !== undefined) {
        var fileUpload = $("#FileUpload1").get(0);
        var files = fileUpload.files;
        var fileData = new FormData();
        for (var i = 0; i < files.length; i++) {
            fileData.append(files[i].name, files[i]);
        }
        var name = $('#txtName').val();
        var productId = $('#ddlProductId').val();
        fileData.append('productId', productId);
        fileData.append('name', name);

        $.ajax({
            url: '/AdminImge/UploadFiles',
            type: "POST",
            contentType: false, // Not to set any content header
            processData: false, // Not to process data
            data: fileData,
            success: function (result) {
                GetAll();
                $('#listImage').show();
            },
            error: function (err) {
                alert(err.statusText);
            }
        });
    } else {
        alert("FormData is not supported.");
    }
});

$(document).on('click', '#btnDelete', function () {
    var id = $(this).data('delete-img-id');
    $.ajax({
        url: '/AdminImge/Delete',
        type: "POST",
        dataType: "json",
        data: { id: id},
        success: function (result) {
            GetAll();
            $('#listImage').show();
        },
        error: function (err) {
            alert(err.statusText);
        }
    });
});

tinymce.init({ selector: 'textarea' });
$('#divForm').hide();
$('#listProduct').show();
GetAll();

function GetAll() {
    $.ajax({
        type: "GET",
        url: "/AdminProduct/GetAll",
        dataType: "html",
        success: function (response) {
            $('#listProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });
}

$(document).on('click', '#btnAddtProduct', function () {
    var id = 0;
    $('#listProduct').hide();
    $('#divForm').show();
    $.ajax({
        type: "GET",
        url: "/AdminProduct/FormInsUp",
        data: { id: id },
        dataType: "html",
        success: function (response) {
            $('#divForm').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });

});

$(document).on('click', '#btnListProduct', function () {
    $('#listProduct').show();
    $('#divForm').hide();
    GetAll();
}); 

$(document).on('click', '[name=btnSave]', function () {
    var id = $('#txtId').val();
    var name = $('#txtName').val();
    var title = $('#txtTitle').val();
    var priceIn = $('#txtPriceIn').val();
    var priceOut = $('#txtPriceOut').val();
    var discount = $('#txtDiscount').val();
    var contentt = $('#txtContentt').val();
    var keywords = $('#txtKeywords').val();
    var quantilyIn = $('#txtQuantilyIn').val();
    var quantilyOut = $('#txtQuantilyOut').val();
    var category = $('#ddlCategory').val();
    var description = tinymce.get("txtDesciption").getContent();
    
    var product = {
        id: id,
        name: name,
        title: title,
        contentt: contentt,
        keywords: keywords,
        description: description,
        discount: discount,
        priceOut: priceOut,
        quantilyIn: quantilyIn,
        quantilyOut: quantilyOut,
        priceIn: priceIn,
        categoryId: category
    };

    $.ajax({
        type: "Post",
        url: "/AdminProduct/InsUp",
        data: product,
        dataType: "json",
        success: function (response) {
            if (response.isSuccess) {
                alert("Lưu thành công");
            }
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });
});

$(document).on('click', '#btnEdit', function () {
    $('#listProduct').hide();
    $('#divForm').show(); 
    var id = $(this).data('edit-product-id');
    $.ajax({
        type: "GET",
        url: "/AdminProduct/FormInsUp",
        data: { id: id },
        dataType: "html",
        success: function (response) {
            $('#divForm').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
        }
    });
});

$(document).on('click', '[name="btnAddImges"]', function () {
    var id = $(this).data('add-product-id');
    debugger;
    $("#AddImagesModal").modal();
    $("#hidProductId").val(id);

});

$(document).on('click', '#btnSaveImge', function () {
    if (window.FormData !== undefined) {
        var fileUpload = $("#FileUpload1").get(0);
        var files = fileUpload.files;
        var fileData = new FormData();
        for (var i = 0; i < files.length; i++) {
            fileData.append(files[i].name, files[i]);
        }
        var productId = $('#hidProductId').val();
        fileData.append('productId', productId);

        $.ajax({
            url: '/AdminImge/UploadProductFiles',
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

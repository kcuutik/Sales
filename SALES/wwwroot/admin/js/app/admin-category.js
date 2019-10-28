

GetAll();
function GetAll() {
    $.ajax({
        type: "GET",
        url: "/AdminCategory/GetAll",
        dataType: "html",
        success: function (response) {
            $('#listCategory').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
}

$(document).on('click', '#btnAdd', function () {
    var id = $('#hidProductId').val();
    var name = $('#txtName').val();
    var isCheck = $("#chkIsActive").is(":checked");
    var description = $('#txtDescription').val();
    
    var url = "Insert";
    if (id !== "") url = "Update";
    $.ajax({
        type: "POST",
        url: "/AdminCategory/" + url,
        dataType: "json",
        data: { id: id, name: name, isCheck: isCheck, description: description},
        success: function (response) {
            $("#addModal").modal("hide");
            GetAll();
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
});

$(document).on('click', '#btnEdit', function () {
    var productId = $(this).data('edit-product-id');
    var productName = $(this).data('edit-product-name');
    var productDescription = $(this).data('edit-product-description');
    var productIscheck = $(this).data('edit-product-ischeck');
    

    $("#addModal").modal();
    $('#hidProductId').val(productId);
    $('#txtName').val(productName);
    if (productIscheck === "False") { document.getElementById("chkIsActive").checked = ""; }
    else { document.getElementById("chkIsActive").checked = "true";}
    $('#txtDescription').val(productDescription);
});

$(document).on('click', '#btnDelete', function () {
    var id = $(this).data('delete-product-id');
    $.ajax({
        type: "POST",
        url: "/AdminCategory/Delete",
        dataType: "json",
        data: { id: id},
        success: function (response) {
            $("#addModal").modal("hide");
            GetAll();
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
});


$(document).on('click', '#btnShowModalAdd', function () {
    $('#hidProductId').val('');
    $('#txtName').val('');
    document.getElementById("chkIsActive").checked = false;
    $('#txtDescription').val('');
});
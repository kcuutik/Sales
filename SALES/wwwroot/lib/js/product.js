
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/san-pham/getIsActive",
        dataType: "html",
        success: function (response) {
            $('#lstProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });

    // Get Id product

});

function GetById() {
    $.ajax({
        type: "GET",
        url: "/san-pham/getById",
        dataType: "html",
        data: { id: id },
        success: function (response) {
            $('#lstProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
} 

$(document).on('click', '[name=btnDetail]', function () {
    debugger;   
    var id = $(this).data('product-id');
    $.ajax({
        type: "GET",
        url: "/san-pham/getById",
        dataType: "html",
        data: { id: id },
        success: function (result) {
            $('#lstProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
});

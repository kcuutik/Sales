
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/san-pham/getAll",
        dataType: "html",
        success: function (response) {
            $('#lstProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });

    // Get Id product
    $.ajax({
        type: "GET",
        url: "/san-pham/getById",
        dataType: "html",
        data: {id: id}
        success: function (response) {
            $('#lstProduct').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
});
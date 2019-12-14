
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

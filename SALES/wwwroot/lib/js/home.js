

GetIsTrend();
function GetIsTrend() {
    $.ajax({
        type: "GET",
        url: "/getIsTrend",
        success: function (response) {
            $('#lstProductTrend').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
} 

GetBestSeller();
function GetBestSeller() {
    $.ajax({
        type: "GET",
        url: "/getIsTrend",
        success: function (response) {
            $('#lstBestSeller').html(response);
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
} 

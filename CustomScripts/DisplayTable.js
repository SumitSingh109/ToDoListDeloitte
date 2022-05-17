$(document).ready(function () {
    $.ajax({
        url: '/ToDoes/CreateToDoTable',
        success: function (output) {
            $('#displayTableDiv').html(output);
        }
    });
});
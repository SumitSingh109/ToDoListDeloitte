$(document).ready(function () {

    $('.IsActiveChecked').change(function () {
        var self = $(this);
        var id = self.attr('id');
        var value = self.prop('checked');

        $.ajax({
            url: '/ToDoes/AjaxEditSingleToDo',
            data: {
                id : id,
                value : value
            },
            type: 'POST',
            success: function (output) {
                $('#displayTableDiv').html(output);
            }
        });
    });
})
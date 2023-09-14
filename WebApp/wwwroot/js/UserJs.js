$(document).ready(function () {
    GetUsers();
})

function GetUsers() {
    $.ajax({
        url: '/users/GetUsers',
        type: 'GET',
        dataType: 'json', 
        contentType: 'application/json;charset=utf-8',
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) { 
                var object = '<tr>';
                object += '<td colspan="5">' + 'Users not available' + '</td>';
                object += '</tr>';
                $('#tblBody').html(object);
            } else {
                var object = '';
                $.each(response, function (index, item) {
                    object += '<tr>';
                    object += '<td>' + item.UserId + '</td>'; 
                    object += '<td>' + item.UserName + '</td>';
                    object += '<td>' + item.Password + '</td>';
                    object += '<td>' + item.Email + '</td>';
                    object += '<td>' + item.Tel + '</td>';
                    object += '<td> <a href="#" class="btn btn-primary btn-sm" onclick="Edit(' + item.UserId + ')" > Edit</a > <a href="#" class="btn btn-danger btn-sm" onclick="Delete(' + item.UserID + ')">Delete</a></td >';
                    object += '</tr>';
                });
                $('#tblBody').html(object);
            }
        },
        error: function () {
            alert('Unable to read the data.');
        }
    });
}

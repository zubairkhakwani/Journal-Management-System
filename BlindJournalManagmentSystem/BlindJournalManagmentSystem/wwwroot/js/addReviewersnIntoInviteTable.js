$(document).ready(function () {
    $("tbody").on("click", "#removeInvite", function () {
        $(this).parent().parent().remove();
    });

    $(".inviteButton").on("click", function () {
        var val = $(this).parent().parent().find("#userEmail").html();
        var row = "<tr><td><input name='reviewersEmails' type='email' class='hidden' value='" + val + "'></input>" + val + "</td><td>pending</td><td><button class='btn btn-danger' id='removeInvite'>remove</button></td></tr>"
        $("#inviteTable").find("tbody").append(row);
    });

    
});
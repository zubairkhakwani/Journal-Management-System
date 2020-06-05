$(document).ready(function () {

    function IsEmail(email) {
        var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (!regex.test(email)) {
            return false;
        } else {
            return true;
        }
    }

    $("#searchButton").click(function () {
        var email = $("#search").val();
        if (IsEmail(email)) {
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    var response = JSON.parse(this.responseText);
                    if (response != null) {

                        var row = "<tr> <td></td>  <td><button type='button' class='btn btn-danger'> remove </button></td>  <td> <input type='hidden' name ='AuthorsEmails' value='" + response.Email + "'/>"+ response.Email +"</td>  <td>" + response.Institution + "</td> </tr>"
                        $("#addAuthorBody").append(row);
                    }
                    else {
                        alert("No User Found Check Email And Try Again");
                    }
                    
                }
            };
            xhttp.open("GET", "https://localhost:44389/Author/searchAuthorByEmail?email=" + email, true);
            xhttp.send();
        }
        else {
            alert("Invalid Email Address");
        }
    });

    $("tbody").on("click", ".btn-danger", function () {
        $(this).parent().parent().remove();
    });

});
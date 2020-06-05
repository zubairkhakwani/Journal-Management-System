$(document).ready(function () {

    function IsEmail(email) {
        
    }

    $("#addFields").click(function () {
        $.each($("#FieldsIds option:selected"), function () {
            
            var row = "<tr>  <td> <input name='FieldsIds' type='hidden' value='" + $(this).val() + "'/>" + $(this).text() + "</td> <td> <button type='button' class='btn btn-danger'> remove </button> </td> </tr>";
            $("#FieldsIds option:selected").prop("selected", false);
            $("#fieldsTable").append(row);
        });
    });

    $("#addCategories").click(function () {
        $.each($("#SubjectCategoriesIds option:selected"), function () {

            var row = "<tr>  <td> <input name='SubjectCategoriesIds' type='hidden' value='" + $(this).val() + "'/>" + $(this).text() + "</td> <td> <button type='button' class='btn btn-danger'> remove </button> </td> </tr>";
            $("#SubjectCategoriesIds option:selected").prop("selected", false);
            $("#categoriesTable").append(row);
        });
    });

    $("tbody").on("click",".btn-danger", function () {
        $(this).parent().parent().remove();
    });

});
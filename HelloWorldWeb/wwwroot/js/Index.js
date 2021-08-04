// JavaScript source code
$(document).ready(function () {
    $("#createButton").click(function () {
        var newcomerName = $("#nameField").val();


        $("#teamList").append(`<li>${newcomerName}</li>`);

        $.ajax({
            url: "/Home/AddTeamMember",
            method: "POST",
            data: {
                teamMember: newcomerName
            },
            success: (result) =>
            {
                $("#teamList").append(`<li>${newcomerName}</li>`);
                $("#nameField").val("");
            }
        })



    })
});
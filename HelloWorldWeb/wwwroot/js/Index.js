// JavaScript source code
$(document).ready(function () {
    $("#createButton").click(function () {
        var newcomerName = $("#nameField").val();


        $("#teamList").append(`<li>${newcomerName}</li>`);

        $.ajax({
            url: "https://localhost:44392/Home/AddTeamMember",
            method: "POST",
            data: {
                "NewTeammate": newcomerName
            },
            success: (result) =>
            {
                $("#teamList").append(`<li>${newcomerName}</li>`);
                $("#nameField").val("");
            }
        })



    })
});
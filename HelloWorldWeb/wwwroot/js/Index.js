// JavaScript source code
$(document).ready(function () {
    $("#add").click(function () {
        var newcomerName = $("#newcomer").val();



        // Remember string interpolation
        $("#list").append(`<li>${newcomerName}</li>`);



        $("#newcomer").val("");
    })
});
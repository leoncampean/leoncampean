// This JS file now uses jQuery. Pls see here: https://jquery.com/
$(document).ready(function () {
    // see https://api.jquery.com/click/
    $("#addMembersButton").click(function () {
        var newcomerName = $("#nameField").val();

        $.ajax({
            url: "/Home/AddTeamMember",
            method: "POST",
            data: {
                teamMember: newcomerName
            },
            success: function (result) {
                // Remember string interpolation
                $("#teamMembers").append(
                    `<li class="member">
                        <span class="name" >${newcomerName}</span>
                        <span class="delete fa fa-remove" onclick="deleteMember(${result})"></span>
                        <span class="pencil fa fa-pencil"></span>
                    </li>`);

                $("#nameField").val("");
                document.getElementById("addMembersButton").disabled = true;
            }
        })
    })

    $('#submit').click(function () {
        const id = $('#editClassmate').attr('member-id');
        console.log(id);
    });

    $("#teamMembers").on("click", ".pencil", function () {
        var targetMemberTag = $(this).closest('li');
        var id = targetMemberTag.attr('member-id');
        var currentName = targetMemberTag.find(".name").text();
        $('#editClassmate').attr("member-id", id);
        $('#classmateName').val(currentName);
        $('#editClassmate').modal('show');
    })

    $("#editClassmate").on("click", "#submit", function () {
        console.log('submit changes to server');
        var id = 5;
        var name = "Leon";
        $.ajax({
        url: "/Home/RenameMember"
        method: "POST",
        data: {
            "id": id,
            "name": name,
        },
            success: function (result) {
                consol.log('cessful rename ${ id }');
               
        }
    })
    })

    $("#editClassmate").on("click", "#cancel", function () {
        console.log('cancel changes');
    })
});

function deleteMember(index) {

    $.ajax({
        url: "/Home/RemoveMember",
        method: "DELETE",
        data: {
            memberIndex: index
        },
        success: function (result) {
            location.reload();
        }
    })
}

(function () {

    $('#nameField').on('change textInput input', function () {
        var inputVal = this.value;
        if (inputVal != "") {
            document.getElementById("addMembersButton").disabled = false;
        } else {
            document.getElementById("addMembersButton").disabled = true;
        }
    });
}());

(function () {
    $("#clearButton").click(function () {
        document.getElementById("nameField").value = "";
    });
}());
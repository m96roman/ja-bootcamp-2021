$(document).on('click', '.btn-edit', function editBtnClick(event) {
    let userId = $(event.target).attr('id').replace("btn-edit-", "");
    setModalToEdit(userId);
});

$(document).on('click', "#launch-create-form", function () {
    setModalToCreate();
    setTimeout(function () {
        $("#modify-form").modal('show');
    }, 1)
});

$(document).on('submit', '#Create-user-form', function (event) {
    event.preventDefault();
    SendModifyRequest("#Create-user-form", createRoute)
});

$(document).on('submit', "#Edit-user-form", function (event) {
    event.preventDefault();
    SendModifyRequest("#Edit-user-form", editRoute, true)
})

function setModalToCreate() {
    $.ajax({
        method: "get",
        url: createRoute,
        processData: "false",
        contentType: "false"
    }).done(function (response) {
        $("#modify-form-container").html(response);
    })
}

function setModalToEdit(Id) {

    var link = editPostRoute;
    link = link.replace("-1", Id);

    $.ajax({
        method: "get",
        url: link,
        processData: "false",
        contentType: "false"
    }).done(function (response) {
        if (response.failure === true) {
            alert("Cannot find this user!");
        } else {
            $("#modify-form-container").html(response);
            setTimeout(function () {
                $("#modify-form").modal('show')
            }, 1);
        }
    })

}

function PopulateUsersList() {
    let filterFormData = new FormData();
    filterFormData.append("LastName", $("#FilterLastName").val())
    filterFormData.append("Name", $("#FilterName").val())

    $.ajax({
        type: 'POST',
        url: filterRoute,
        data: filterFormData,
        processData: false,
        contentType: false
    }).done(function (response) {
        $("#user-list").html(response);
    });
}

function SendModifyRequest(form, url, edit = false) {
    let formData = new FormData();

    formData.append("Name", $(form + " input[name=Name]").val())

    formData.append("LastName", $(form + " input[name=LastName]").val())
    let id = $(form + " input[name=Id]").val()
    formData.append("Id", id);

    $.ajax({
        type: 'POST',
        url: url,
        data: formData,
        processData: false,
        contentType: false
    }).done(function (response) {
        if (response.success === true) {
            $(form)[0].reset()

            PopulateUsersList();

            if (edit) {
                setTimeout(function () {
                    setModalToEdit(id);
                }, 1)
            }

        } else {
            //if the form has model state errors
            $("#modify-form-container").html(response);
        }
    });
}

$().ready(function () {

    //filter handlers

    $("#FilterName").keyup(function () {
        PopulateUsersList();
    })

    $("#FilterLastName").keyup(function () {
        PopulateUsersList();
    })

    $("#FilterForm").on('reset', function () {
        setTimeout(function () {
            PopulateUsersList();
        });
    });
});

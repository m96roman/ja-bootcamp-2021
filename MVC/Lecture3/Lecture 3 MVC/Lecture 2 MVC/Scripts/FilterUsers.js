let searchInput = document.getElementById('searchInput');
console.log(searchInput);
searchInput.addEventListener('keyup', LoadData);

function LoadData() {
    console.log('blur');
    $("#tblUsers tbody tr").remove();
    $.ajax({
        type: 'GET',
        url: "http://localhost:62950/User/FilterUsers/" + $(this).val(),
        dataType: 'json',
        success: function (data) {
            console.log(data)
            $.each(data, function (i, item) {
                let rows = "<tr>"
                    + "<td class='prtoducttd'>" + item.Id + "</td>"
                    + "<td class='prtoducttd'>" + item.Name + "</td>"
                    + "<td class='prtoducttd'>" + item.LastName + "</td>"
                    + "</tr>";
                $('#tblUsers tbody').append(rows);
            });
        },
        error: function (error) {
            if (error.status == 404) {
                console.log("ERROR: Url is not righr")
                console.log(error.status)
            }
        }
    });
}

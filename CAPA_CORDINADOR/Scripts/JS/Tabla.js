/*const btnOpenFile = document.getElementById("OpenFile");

var tabladata;

btnOpenFile.addEventListener("click", function () {
    jQuery.ajax({
        url: '@Url.Action("getSolicitudesPrueba", "Reporte")',
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset= utf- 8",
        success: function (data) {

            alert("Se activó el ajax");
                    }
    })
})



tabladata = $("#tabla").DataTable({
    responsive: true,
    orderign: false,
    "ajax": {
        url: '@Url.Action("getSolicitudesPrueba", "Reporte")',
        type: "GET",
        dataType: "json",
    },
    "columns": [

        { "data": "us_name" },
        { "data": "us_lastname" },
        { "data": "cu_name" },
        {
            "data": "so_date",
            "render": function (data, type, full, meta) {
                var date = new Date(parseInt(data.substr(6)));
                var day = date.getDate().toString().padStart(2, '0');
                var month = (date.getMonth() + 1).toString().padStart(2, '0');
                var year = date.getFullYear().toString();
                return day + "/" + month + "/" + year;
            }
        },
        { "data": "so_type" },
        { "data": "pf_name" },
        {
            "defaultContent":
                '<div class="d-flex flex-wrap justify-content-evenly"> '
                + '<button type="button" class="btn btn-outline-success btn-sm"><i class="bi bi-folder-symlink"></i> Abrir</button>'
                + '<button type="button" class="btn btn-outline-primary btn-sm"><i class="bi bi-check2-all"></i> Aprobar</button>'
                + '<button type="button" class="btn btn-outline-danger btn-sm"><i class="bi bi-x-lg"></i> Rechazar</button>'
                + '</div>',
            "orderable": false,
            "searchable": false,
        }
    ]
})*/
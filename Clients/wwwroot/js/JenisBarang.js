var table = null;
$(document).ready(function () {
    debugger;
    table = $('#JenisBarang').DataTable({
        "ajax": {
            url: "/JenisBarang/LoadJenisBarang",
            type: "GET",
            datatype: "json"
        },
        "columns": [
            {
                data: null, render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { data: "jenis_Barang" },
            {
                data: null, render: function (data, type, row) {
                    return `<td>
                    <div class='btn-group'>
                        <button type='button' class='btn btn-warning' id='BtnEdit' data-toggle='tooltip' data-original-title='Edit' onclick=GetById('` + row.id + `');><i class='fas fa-pencil-alt'></i></button>
                        <button type='button' class='btn btn-danger' id='BtnDelete' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete' onclick=Delete('` + row.id + `');><i class='fa fa-trash'></i></button>
                    </div>
                    </td>`;
                }
            },
        ]
    });

});
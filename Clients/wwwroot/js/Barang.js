var jenis = []
var table = null;
$(document).ready(function () {
    table = $('#Barang').DataTable({
        "ajax": {
            url: "/Barang/LoadBarang",
            type: "GET",
            datatype: "json"
        },

        "columns": [
            {
                data: null, render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { data: "nama_Barang" },
            { data: "stok" },
            { data: "jenis_Barang" },
            {
                data: null, render: function (data, type, row) {
                    return `<td>
                    <div class='btn-group'>
                        <button type='button' class='btn btn-warning' id='BtnEdit' data-toggle='modal' data-target='#modalBrg' onclick='GetById(${row.id});'><i class='fas fa-pencil-alt'></i></button>

                        <button type='button' class='btn btn-danger' id='BtnDelete' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete' onclick='Delete(${row.id});'><i class='fa fa-trash'></i></button>
                    </div>
                    </td>`;
                }
            },
        ]
    });

    LoadJenisBarang($('#jenisbarang'));
});

function ClearForm() {
    $('#namabarang').val('');
    $('#stok').val('');
    $('#jenisbarang').val(0);
}

$('#BtnAdd').click(function () {
    $('.modal-title').html('Tambah Barang');
    $('#Update').hide();
})

function LoadJenisBarang(element) {
    if (jenis.length === 0) {
        $.ajax({
            type: "GET",
            url: "/JenisBarang/LoadJenisBarang",
            success: function (data) {
                jenis = data.data;
                renderJenisBarang(element);
            }
        })
    } else {
        renderJenisBarang(element);
    }
}

function renderJenisBarang(element) {
    var $ele = $(element);
    $ele.empty();
    $ele.append($('<option/>').val('0').text('Pilih Jenis Barang').hide());
    $.each(jenis, function (i, val) {
        $ele.append($('<option/>').val(val.id).text(val.jenis_Barang));
    })
}

function Save() {
    var barang = new Object();
    barang.Nama_Barang = $('#namabarang').val();
    barang.Stok = $('#stok').val();
    barang.Jenis_Id = $('#jenisbarang').val();

    $.ajax({
        type: 'POST',
        url: '/Barang/InsertOrUpdate',
        data: barang,
    }).then((result) => {
        if (result.statusCode == 200) {
            Swal.fire({
                icon: 'success',
                position: 'center',
                title: 'Tambah Barang Berhasil!',
                timer: 2500
            }).then(function () {
                table.ajax.reload();
                $('#modalBrg').modal('hide');
                ClearForm();
            })
        }
        else {
            Swal.fire({
                icon: 'error',
                position: 'center',
                title: 'Error',
                text: result.error,
                timer: 2500
            })
        }
    })
}

function GetById(id) {
    debugger
    $.ajax({
        url: "/Barang/GetById/" + id,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (result) {
            $('#idbarang').val(result.id);
            $('#namabarang').val(result.nama_Barang);
            $('#stok').val(result.stok);
            $('#jenisbarang').val(result.jenis_Id);
            $('#modalBrg').modal('show');
            $('#Update').show();
            $('#Save').hide();
        },
        error: function (errormessage) {
            Swal.fire({
                icon: 'error',
                position: 'center',
                title: 'Error',
                text: result.error,
                timer: 2500
            })
        }
    })
}

function Update() {
    
    Swal.fire({
        icon: 'question',
        title: "Yakin ingin menyimpan Perubahan?",
        showCancelButton: true,
        confirmButtonText: "Ya",
        cancelButtonText: "Tidak"
    }).then((result) => {
        if (result.value) {
            var barang = new Object();
            barang.Id = $('#idbarang').val();
            barang.Nama_Barang = $('#namabarang').val();
            barang.Stok = $('#stok').val();
            barang.Jenis_Id = $('#jenisbarang').val();

            $.ajax({
                type: 'POST',
                url: '/Barang/InsertOrUpdate',
                data: barang
            }).then((result) => {
                debugger;
                if (result.statusCode === 200) {
                    Swal.fire({
                        icon: 'success',
                        position: 'center',
                        title: 'Update Barang Berhasil!',
                        timer: 2500
                    }).then(function () {
                        table.ajax.reload();
                        $('#modalBrg').modal('hide');
                        ClearForm();
                    });
                } else {
                    Swal.fire({
                        icon: 'error',
                        position: 'center',
                        title: 'Error',
                        text: result.error,
                        timer: 2500
                    })
                }
            })
        } else {
            //do nothing
        }
    });
}

function Delete(id) {
    Swal.fire({
        icon: 'warning',
        title: "Yakin ingin menghapus Data?",
        showCancelButton: true,
        confirmButtonText: "Ya",
        cancelButtonText: "Tidak"
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: 'POST',
                url: '/Barang/Delete',
                data: { Id: id }
            }).then((result) => {
                debugger;
                if (result.statusCode === 200) {
                    Swal.fire({
                        icon: 'success',
                        position: 'center',
                        title: 'Hapus Barang Berhasil!',
                        timer: 2500
                    }).then(function () {
                        table.ajax.reload();
                    });
                } else {
                    Swal.fire({
                        icon: 'error',
                        position: 'center',
                        title: 'Error',
                        text: result.error,
                        timer: 2500
                    })
                }
            })
        } else {
            //do nothing
        }
    });
}
class Emprestimo {
    clickUsuarioVazio() {
        if ($('#input-usuario-selecionado').attr('data-usuario-id') != "0" || $('#input-usuario-selecionado').attr('data-usuario-id') != undefined) {
            $('#div-usuario-selecionado').hide();
            $('#input-usuario-selecionado').attr('data-usuario-id', 0).val('');
            $('#div-table-usuario').show();
        }

        let rows = '<tr><td style="text-align: center;" colspan="2">Nenhum Usuário Encontrado</td></tr>';
        $('#table-usuario tbody').html(rows);
    }

    clickLivroVazio() {
        if ($('#input-livro-selecionado').attr('data-livro-id') != "0" || $('#input-livro-selecionado').attr('data-livro-id') != undefined) {
            $('#div-livro-selecionado').hide();
            $('#input-livro-selecionado').attr('data-livro-id', 0).val('');
            $('#div-table-livro').show();
        }

        rows = '<tr><td style="text-align: center;" colspan="2">Nenhum Livro Encontrado</td></tr>';
        $('#table-livro tbody').html(rows);
    }

    clickConsultarUsuario() {
        let valor = $('#input-consulta-usuario').val();
        if (valor == "") {
            this.clickUsuarioVazio();
            return;
        }

        $.ajax({
            url: '/emprestimo/consultausuario',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(valor)
        }).done(function (response) {
            let lstUsuario = response.usuarios;
            let rows = '';
            if (lstUsuario.length > 0) {
                $.each(lstUsuario, function (i, v) {
                    rows += '<tr data-usuario-id="' + v.id + '"><td>' + v.nome + '</td><td>' + v.instituicaoEnsino.nome + '</td></tr>';
                });
            } else {
                rows = '<tr><td style="text-align: center;" colspan="2">Nenhum Usuário Encontrado</td></tr>';
            }
            $('#table-usuario tbody').html(rows);
            $('#input-consulta-usuario').val('');
        });
    }

    clickConsultarLivro() {
        let valor = $('#input-consulta-livro').val();
        if (valor == "") {
            this.clickLivroVazio();
            return;
        }

        $.ajax({
            url: '/emprestimo/consultalivro',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(valor)
        }).done(function (response) {
            let lstLivro = response.livros;
            let rows = '';
            if (lstLivro.length > 0) {
                $.each(lstLivro, function (i, v) {
                    rows += '<tr data-livro-id="' + v.id + '"><td>' + v.titulo + '</td><td>' + v.autor + '</td></tr>';
                });
            } else {
                rows = '<tr><td style="text-align: center;" colspan="2">Nenhum Livro Encontrado</td></tr>';
            }
            $('#table-livro tbody').html(rows);
            $('#input-consulta-livro').val('');
        });
    }

    clickReservar() {
        $('#div-reserva').show();
    }

    clickDevolver(id) {
        $.ajax({
            url: '/emprestimo/devolver',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(id)
        }).done(function (response) {
            Swal.fire({
                icon: 'success',
                title: 'Operação realizada com sucesso!',
                showConfirmButton: false,
                timer: 1500
            }).then((result) => {
                location.reload();
            });
        });
    }
}

var emprestimo = new Emprestimo();

$(document).ready(function () {
    $("#table-usuario").on('click', 'tr', function (e) {
        let usuarioId = $(this).attr('data-usuario-id');
        $('#input-usuario-selecionado').attr('data-usuario-id', usuarioId).val($(this).find('td:first').text());
        $('#input-usuario-selecionado-id').val(usuarioId);
        $('#div-table-usuario').hide();
        $('#div-usuario-selecionado').show();
    });

    $("#table-livro").on('click', 'tr', function (e) {
        let livroId = $(this).attr('data-livro-id');
        $('#input-livro-selecionado').attr('data-livro-id', livroId).val($(this).find('td:first').text());
        $('#input-livro-selecionado-id').val(livroId);
        $('#div-table-livro').hide();
        $('#div-livro-selecionado').show();
    });
});
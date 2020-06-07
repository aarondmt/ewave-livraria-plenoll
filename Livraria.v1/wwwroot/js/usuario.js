class Usuario {
    clickAlterarStatus(id, button) {
        let funcao = $(button).prop('title');
        Swal.fire({
            title: 'Atenção!',
            icon: 'warning',
            html: 'Você gostaria de <strong>' + funcao + '</strong> este Usuário?',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sim, ' + funcao + '!',
            cancelButtonText: 'Não!'
        }).then((result) => {
            if (result.value) {
                this.chamadaAjax(id);
            }
        });
    }

    chamadaAjax(id) {
        $.ajax({
            url: '/usuario/alterarstatusconfirmado',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(id)
        }).done(function (response) {
            if (response) {
                Swal.fire({
                    icon: 'success',
                    title: 'Operação realizada com sucesso!',
                    showConfirmButton: false,
                    timer: 1500
                }).then((result) => {
                    location.reload();
                });
            }
        });
    }
}

var usuario = new Usuario();
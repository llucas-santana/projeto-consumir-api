function entrar(param) {

    var url = 'https://localhost:7037/api/login/autenticar';

    var dados = {
        Id : 0,
        Login: $('#txtLogin').val(),
        Senha: $('#txtSenha').val(),
        Papel: '',
        Hash: param
    };

    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(dados),
        success: function(jsonResult) {

            if (jsonResult.status) {
                sessionStorage.setItem("token", jsonResult.token);

                sessionStorage.setItem("Seguranca", param);

                window.location.href = jsonResult.caminho;
            }
            else {
                alert(jsonResult.mensagem);
            }

        },
        failure: function (response) {
            alert("Erro ao carregar os dados: " + response);
        }
    });
}
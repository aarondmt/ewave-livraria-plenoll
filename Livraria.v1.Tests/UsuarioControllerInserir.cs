using Livraria.v1.Controllers;
using Livraria.v1.Models;
using Livraria.v1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Livraria.v1.Tests
{
    public class UsuarioControllerInserir
    {
        [Fact]
        public void DadaUsuarioComInformacoesValidasDeveRetornarRedirectToActionResult()
        {
            //arrange
            var mockUsuario = new Mock<IUsuarioRepository>();
            var mockIE = new Mock<IInstituicaoEnsinoRepository>();
            mockIE.Setup(r => r.GetInstituicaoEnsinoId(20))
                .Returns(new InstituicaoEnsino()
                {
                    Ativo = true,
                    Nome = "Teste",
                    Cnpj = "Teste",
                    Endereco = "Teste",
                    Id = 20
                });
            var controller = new UsuarioController(mockUsuario.Object, mockIE.Object);
            var model = new Usuario();
            model.Nome = "Teste";
            model.Ativo = true;
            model.Cpf = "00000000";
            model.Endereco = "Rua de Teste, 00";
            model.InstituicaoEnsinoId = 20;

            //act
            var retorno = controller.Inserir(model);

            //assert
            Assert.IsType<RedirectToActionResult>(retorno);
        }
    }
}

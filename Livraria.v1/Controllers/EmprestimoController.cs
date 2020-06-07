using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.v1.Models;
using Livraria.v1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.v1.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository emprestimoRepository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly ILivroRepository livroRepository;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository
            , IUsuarioRepository usuarioRepository, ILivroRepository livroRepository)
        {
            this.emprestimoRepository = emprestimoRepository;
            this.usuarioRepository = usuarioRepository;
            this.livroRepository = livroRepository;
        }

        public IActionResult EmprestimoHome()
        {
            return View(emprestimoRepository.GetEmprestimo());
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Inserir(Emprestimo emprestimo)
        {
            emprestimo.DataDevolucao = emprestimo.DataEmprestimo.AddDays(30);
            emprestimoRepository.Inserir(emprestimo);
            return RedirectToAction("EmprestimoHome");
        }

        [HttpPost]
        public IActionResult Devolver([FromBody]int id)
        {
            emprestimoRepository.Devolver(id);
            return RedirectToAction(nameof(EmprestimoHome));
        }

        [HttpPost]
        public IActionResult Atraso([FromBody] int id)
        {
            emprestimoRepository.Atraso(id);
            return RedirectToAction(nameof(EmprestimoHome));
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Reservar(Emprestimo emprestimo)
        {
            emprestimo.DataDevolucao = emprestimo.DataEmprestimo.AddDays(30);
            emprestimoRepository.Inserir(emprestimo);
            return RedirectToAction("EmprestimoHome");
        }

        [HttpPost]
        public ConsultaUsuarioResponse ConsultaUsuario([FromBody] string valor)
        {
            return usuarioRepository.GetUsuarioPorNomeOuCpf(valor);
        }

        [HttpPost]
        public ConsultaLivroResponse ConsultaLivro([FromBody] string valor)
        {
            return livroRepository.GetLivroPorTituloOuAutor(valor);
        }
    }
}

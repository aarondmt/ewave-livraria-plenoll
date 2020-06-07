using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.v1.Models;
using Livraria.v1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livraria.v1.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            this.livroRepository = livroRepository;
        }

        public IActionResult LivroHome()
        {
            return View(livroRepository.GetLivro());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = livroRepository.GetLivro(id).FirstOrDefault();
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Inserir(Livro livro)
        {
            if (ModelState.IsValid)
            {
                livro.Ativo = true;
                livroRepository.Inserir(livro);
                return RedirectToAction("LivroHome");
            }
            return View(livro);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = livroRepository.GetLivro(id).FirstOrDefault();
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Livro livro)
        {
            if (id != livro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    livroRepository.Atualizar(livro);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!livroRepository.LivroExists(livro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("LivroHome");
            }
            return View(livro);
        }

        public IActionResult AlterarStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = livroRepository.GetLivro(id).FirstOrDefault();
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livroes/Delete/5
        [HttpPost]
        public IActionResult AlterarStatusConfirmado([FromBody]int id)
        {
            livroRepository.AlterarStatus(id);
            return RedirectToAction("LivroHome");
        }
    }
}

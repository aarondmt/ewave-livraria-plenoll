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
    public class InstituicaoEnsinoController : Controller
    {
        private readonly IInstituicaoEnsinoRepository instituicaoEnsinoRepository;

        public InstituicaoEnsinoController(IInstituicaoEnsinoRepository instituicaoEnsinoRepository)
        {
            this.instituicaoEnsinoRepository = instituicaoEnsinoRepository;
        }

        public IActionResult InstituicaoEnsinoHome()
        {
            return View(instituicaoEnsinoRepository.GetInstituicaoEnsino());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicaoEnsino = instituicaoEnsinoRepository.GetInstituicaoEnsino(id).FirstOrDefault();
            if (instituicaoEnsino == null)
            {
                return NotFound();
            }

            return View(instituicaoEnsino);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(InstituicaoEnsino instituicaoEnsino)
        {
            if (ModelState.IsValid)
            {
                instituicaoEnsino.Ativo = true;
                instituicaoEnsinoRepository.Inserir(instituicaoEnsino);
                return RedirectToAction("InstituicaoEnsinoHome");
            }

            return View(instituicaoEnsino);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicaoEnsino = instituicaoEnsinoRepository.GetInstituicaoEnsino(id).FirstOrDefault();
            if (instituicaoEnsino == null)
            {
                return NotFound();
            }
            return View(instituicaoEnsino);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, InstituicaoEnsino instituicaoEnsino)
        {
            if (id != instituicaoEnsino.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    instituicaoEnsinoRepository.Atualizar(instituicaoEnsino);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!instituicaoEnsinoRepository.InstituicaoEnsinoExists(instituicaoEnsino.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("InstituicaoEnsinoHome");
            }
            return View(instituicaoEnsino);
        }

        public IActionResult AlterarStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicaoEnsino = instituicaoEnsinoRepository.GetInstituicaoEnsino(id).FirstOrDefault();
            if (instituicaoEnsino == null)
            {
                return NotFound();
            }

            return View(instituicaoEnsino);
        }

        // POST: Livroes/Delete/5
        [HttpPost]
        public IActionResult AlterarStatusConfirmado([FromBody] int id)
        {
            instituicaoEnsinoRepository.AlterarStatus(id);
            return RedirectToAction("InstituicaoEnsinoHome");
        }
    }
}

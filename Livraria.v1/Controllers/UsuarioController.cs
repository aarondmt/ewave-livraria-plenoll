using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.v1.Models;
using Livraria.v1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Livraria.v1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IInstituicaoEnsinoRepository instituicaoEnsinoRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository,
            IInstituicaoEnsinoRepository instituicaoEnsinoRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.instituicaoEnsinoRepository = instituicaoEnsinoRepository;
        }

        public IActionResult UsuarioHome()
        {
            return View(usuarioRepository.GetUsuario());
        }

        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = usuarioRepository.GetUsuario(id).FirstOrDefault();
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        public IActionResult Inserir()
        {
            IList<InstituicaoEnsino> itens = instituicaoEnsinoRepository.GetInstituicaoEnsino();
            if (itens.Count > 0)
            {
                ViewBag.Instituicoes = itens.Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
                return View();
            }

            throw new ArgumentException("Erro ao carregar as Instituições de Ensino");
        }

        [HttpPost]
        public IActionResult Inserir(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Ativo = true;
                usuarioRepository.Inserir(usuario);
                return RedirectToAction(nameof(UsuarioHome));
            }
            return View(usuario);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IList<InstituicaoEnsino> itens = instituicaoEnsinoRepository.GetInstituicaoEnsino();
            if (itens == null || itens.Count == 0)                
                return NotFound();

            var usuario = usuarioRepository.GetUsuario(id).FirstOrDefault();
            if (usuario == null)
            {
                return NotFound();
            }

            ViewBag.Instituicoes = itens.Select(c => new SelectListItem() 
            { 
                Text = c.Nome, 
                Value = c.Id.ToString(), 
                Selected = (c.Id == usuario.InstituicaoEnsino.Id) 
            }).ToList();

            return View(usuario);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuarioRepository.Atualizar(usuario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usuarioRepository.UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("UsuarioHome");
            }
            return View(usuario);
        }

        public IActionResult AlterarStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = usuarioRepository.GetUsuario(id).FirstOrDefault();
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Livroes/Delete/5
        [HttpPost]
        public IActionResult AlterarStatusConfirmado([FromBody] int id)
        {
            usuarioRepository.AlterarStatus(id);
            return RedirectToAction("UsuarioHome");
        }
    }
}

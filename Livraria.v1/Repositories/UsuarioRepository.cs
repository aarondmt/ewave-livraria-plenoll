using Livraria.v1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Inserir(Usuario novoUsuario);
        Usuario Atualizar(Usuario usuario);
        void AlterarStatus(int id);
        IList<Usuario> GetUsuario(int? id = null);
        ConsultaUsuarioResponse GetUsuarioPorNomeOuCpf(string stringConsulta);
        bool UsuarioExists(int id);
    }
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        //private readonly IHttpContextAccessor httpContextAccessor;
        public UsuarioRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void AlterarStatus(int id)
        {
            var usuario = GetUsuario(id).FirstOrDefault();
            usuario.Ativo = !usuario.Ativo;
            contexto.SaveChanges();
        }

        public Usuario Atualizar(Usuario usuario)
        {
            contexto.Update(usuario);
            contexto.SaveChanges();
            return usuario;
        }

        public IList<Usuario> GetUsuario(int? id = null)
        {
            if (id != null)
            {
                return dbSet
                        .Where(i => i.Id == id)
                        .Include(ie => ie.InstituicaoEnsino)
                        .ToList();
            }

            return dbSet.Include(ie => ie.InstituicaoEnsino).ToList();
        }

        public ConsultaUsuarioResponse GetUsuarioPorNomeOuCpf(string stringConsulta)
        {
            if (!string.IsNullOrEmpty(stringConsulta))
            {
                var usuarios = dbSet
                    .Where(u => u.Ativo == true
                                && (EF.Functions.Like(u.Nome, $"%{stringConsulta}%")
                                || EF.Functions.Like(u.Cpf, $"%{stringConsulta}%")))
                    .Include(ie => ie.InstituicaoEnsino)
                    .ToList();

                List<Usuario> usuariosAux = new List<Usuario>();
                usuariosAux.AddRange(usuarios);

                foreach (var usuario in usuariosAux)
                {
                    if (contexto.Set<Emprestimo>().Where(e => e.Usuario.Id == usuario.Id).Count() > 1)
                    {
                        usuarios.Remove(usuario);
                    }
                    else
                    {
                        contexto.Entry(usuario)
                            .Collection(e => e.Emprestimos)
                            .Query()
                            .Include(a => a.Atraso)
                            .Load();

                        if (usuario.Emprestimos.Count > 0)
                        {
                            foreach (var emprestimo in usuario.Emprestimos)
                            {
                                if (emprestimo.Atraso != null && (emprestimo.Atraso.DataRetorno == null || emprestimo.Atraso.DataRetorno > DateTime.Now))
                                {
                                    usuarios.Remove(usuario);
                                    break;
                                }
                            }
                        }
                    }
                }

                return new ConsultaUsuarioResponse(usuarios);
            }

            throw new ArgumentException("Faltou parametro não encontrado.");
        }

        public Usuario Inserir(Usuario novoUsuario)
        {
            dbSet.Add(novoUsuario);
            contexto.SaveChanges();
            return novoUsuario;
        }

        public bool UsuarioExists(int id)
        {
            return dbSet.Any(u => u.Id == id);
        }
    }
}

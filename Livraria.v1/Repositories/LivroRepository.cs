using Livraria.v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface ILivroRepository
    {
        Livro Inserir(Livro novoLivro);
        Livro Atualizar(Livro livro);
        void AlterarStatus(int id);
        IList<Livro> GetLivro(int? id = null);
        ConsultaLivroResponse GetLivroPorTituloOuAutor(string stringConsulta);
        bool LivroExists(int id);
    }
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Livro Atualizar(Livro livro)
        {
            contexto.Update(livro);
            contexto.SaveChanges();
            return livro;
        }

        public ConsultaLivroResponse GetLivroPorTituloOuAutor(string stringConsulta)
        {
            if (!string.IsNullOrEmpty(stringConsulta))
            {
                var livros = dbSet
                    .Where(l => l.Ativo == true
                                && (EF.Functions.Like(l.Titulo, $"%{stringConsulta}%")
                                || EF.Functions.Like(l.Autor, $"%{stringConsulta}%")))
                    .ToList();

                var livrosAux = livros;

                foreach (var livro in livrosAux)
                {
                    if (contexto.Set<Emprestimo>().Any(e => e.Livro.Id == livro.Id))
                    {
                        livros.Remove(livro);
                    }
                }

                return new ConsultaLivroResponse(livros);
            }

            throw new ArgumentException("Faltou parametro não encontrado.");
        }

        public IList<Livro> GetLivro(int? id = null)
        {
            if (id != null)
            {
                return dbSet.Where(i => i.Id == id).ToList();
            }

            return dbSet.ToList();
        }

        public Livro Inserir(Livro novoLivro)
        {
            dbSet.Add(novoLivro);
            contexto.SaveChanges();
            return novoLivro;
        }

        public void AlterarStatus(int id)
        {
            var livro = GetLivro(id).FirstOrDefault();
            livro.Ativo = !livro.Ativo;
            contexto.SaveChanges();
        }

        public bool LivroExists(int id)
        {
            return dbSet.Any(l => l.Id == id);
        }
    }
}

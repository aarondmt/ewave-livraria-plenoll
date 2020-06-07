using Livraria.v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface IEmprestimoRepository
    {
        IList<Emprestimo> GetEmprestimo(int? id = null);
        void Inserir(Emprestimo novoEmprestimo);
        void Devolver(int id);
    }
    public class EmprestimoRepository : BaseRepository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Devolver(int id)
        {
            var emprestimo = dbSet.Where(e => e.Id == id).FirstOrDefault();
            emprestimo.DataDevolvido = DateTime.Now;
            contexto.Update(emprestimo);
            contexto.SaveChanges();
        }

        public IList<Emprestimo> GetEmprestimo(int? id = null)
        {
            if (id != null)
            {
                var emprestimos = dbSet
                    .Include(l => l.Livro)
                    .Include(u => u.Usuario)
                    .Where(i => i.Id == id)
                    .ToList();
                return emprestimos;
            }

            return dbSet
                    .Include(l => l.Livro)
                    .Include(u => u.Usuario)
                    .ToList();
        }

        public void Inserir(Emprestimo novoEmprestimo)
        {
            dbSet.Add(novoEmprestimo);
            contexto.SaveChanges();
        }
    }
}

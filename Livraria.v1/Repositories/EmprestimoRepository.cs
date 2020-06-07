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
        void Reservar(Reserva reserva);
        void Devolver(int id);
        void Atraso(int id);
    }
    public class EmprestimoRepository : BaseRepository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Atraso(int id)
        {
            var emprestimo = dbSet.Where(e => e.Id == id).FirstOrDefault();
            if (emprestimo != null)
            {
                contexto.Set<Atraso>().Add(new Atraso() { EmprestimoId = emprestimo.Id });
                contexto.SaveChanges();
            }
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
                    .Include(a => a.Atraso)
                    .Where(i => i.Id == id)
                    .ToList();
                return emprestimos;
            }

            return dbSet
                    .Include(l => l.Livro)
                    .Include(u => u.Usuario)
                    .Include(a => a.Atraso)
                    .ToList();
        }

        public void Inserir(Emprestimo novoEmprestimo)
        {
            dbSet.Add(novoEmprestimo);
            contexto.SaveChanges();
        }

        public void Reservar(Reserva reserva)
        {
            contexto.Set<Reserva>().Add(reserva);
            contexto.SaveChanges();
        }
    }
}

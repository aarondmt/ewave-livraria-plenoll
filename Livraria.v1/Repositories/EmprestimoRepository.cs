using Livraria.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface IEmprestimoRepository
    {
        IList<Emprestimo> GetEmprestimo(int? id = null);
    }
    public class EmprestimoRepository : BaseRepository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Emprestimo> GetEmprestimo(int? id = null)
        {
            if (id != null)
            {
                return dbSet.Where(i => i.Id == id).ToList();
            }

            return dbSet.ToList();
        }
    }
}

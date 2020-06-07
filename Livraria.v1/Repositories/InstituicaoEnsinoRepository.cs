using Livraria.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface IInstituicaoEnsinoRepository
    {
        InstituicaoEnsino Inserir(InstituicaoEnsino novaInstituicao);
        InstituicaoEnsino Atualizar(InstituicaoEnsino instituicaoEnsino);
        void AlterarStatus(int id);
        IList<InstituicaoEnsino> GetInstituicaoEnsino(int? id = null);
        bool InstituicaoEnsinoExists(int id);
    }
    public class InstituicaoEnsinoRepository : BaseRepository<InstituicaoEnsino>, IInstituicaoEnsinoRepository
    {
        public InstituicaoEnsinoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void AlterarStatus(int id)
        {
            var instituicaoEnsino = GetInstituicaoEnsino(id).FirstOrDefault();
            instituicaoEnsino.Ativo = !instituicaoEnsino.Ativo;
            contexto.SaveChanges();
        }

        public InstituicaoEnsino Atualizar(InstituicaoEnsino instituicaoEnsino)
        {
            contexto.Update(instituicaoEnsino);
            contexto.SaveChanges();
            return instituicaoEnsino;
        }

        public IList<InstituicaoEnsino> GetInstituicaoEnsino(int? id = null)
        {
            if (id != null)
            {
                return dbSet.Where(i => i.Id == id).ToList();
            }

            return dbSet.ToList();
        }

        public InstituicaoEnsino Inserir(InstituicaoEnsino novaInstituicao)
        {
            dbSet.Add(novaInstituicao);
            contexto.SaveChanges();
            return novaInstituicao;
        }

        public bool InstituicaoEnsinoExists(int id)
        {
            return dbSet.Any(ie => ie.Id == id);
        }
    }
}

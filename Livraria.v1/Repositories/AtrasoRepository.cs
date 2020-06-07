using Livraria.v1.Models;

namespace Livraria.v1.Repositories
{
    public interface IAtrasoRepository
    {

    }
    public class AtrasoRepository : BaseRepository<Atraso>, IAtrasoRepository
    {
        public AtrasoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}

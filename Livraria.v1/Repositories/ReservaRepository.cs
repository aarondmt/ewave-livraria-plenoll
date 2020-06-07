using Livraria.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public interface IReservaRepository
    {

    }
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}

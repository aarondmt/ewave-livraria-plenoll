using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    [DataContract]
    public class Reserva : BaseModel
    {
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataReserva { get; set; } = DateTime.Now;
        public DateTime DataRetirada { get; set; }
    }
}

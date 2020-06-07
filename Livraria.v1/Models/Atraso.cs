using System;
using System.Runtime.Serialization;

namespace Livraria.v1.Models
{
    [DataContract]
    public class Atraso : BaseModel
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public DateTime? DataRetorno { get; set; }
    }
}

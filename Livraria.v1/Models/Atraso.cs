using System;
using System.Runtime.Serialization;

namespace Livraria.v1.Models
{
    [DataContract]
    public class Atraso : BaseModel
    {
        public int EmprestimoId { get; set; }
        public Emprestimo Emprestimo { get; set; }
        public DateTime? DataRetorno { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    public class Emprestimo : BaseModel
    {
        public int LivroId { get; set; }
        public int UsuarioId { get; set; }
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
        public DateTime? DataDevolucao { get; set; }
        public bool Devolvido { get; set; }
    }
}

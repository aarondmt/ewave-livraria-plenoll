using System;

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
        public DateTime? DataDevolvido { get; set; }
        public Atraso Atraso { get; set; }
    }
}

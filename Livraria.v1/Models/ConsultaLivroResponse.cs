using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    public class ConsultaLivroResponse
    {
        public ConsultaLivroResponse(IList<Livro> livros)
        {
            Livros = livros;
        }

        public IList<Livro> Livros { get; }
    }
}

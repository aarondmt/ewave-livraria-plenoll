using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    public class ConsultaUsuarioResponse
    {
        public ConsultaUsuarioResponse(IList<Usuario> usuarios)
        {
            Usuarios = usuarios;
        }

        public IList<Usuario> Usuarios { get; set; }
    }
}

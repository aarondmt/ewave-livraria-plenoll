using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    [DataContract]
    public class Livro : BaseModel
    {
        [Required]
        [DataMember]
        public string Titulo { get; set; }

        public string Sinopse { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        [DataMember]
        public string Autor { get; set; }
        public IList<Emprestimo> Emprestimos { get; set; }

        //[Required]
        //public []byte Capa { get; private set; }
    }
}

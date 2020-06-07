using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Livraria.v1.Models
{
    [DataContract]
    public class Usuario : BaseModel
    {
        [Required]
        [DataMember]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        [Required]
        public string Endereco { get; set; }

        [ForeignKey("InstituicaoEnsino")]
        public int InstituicaoEnsinoId { get; set; }
        [DataMember]
        public virtual InstituicaoEnsino InstituicaoEnsino { get; set; }
    }
}

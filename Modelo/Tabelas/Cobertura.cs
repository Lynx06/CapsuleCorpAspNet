using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Tabelas
{
    public class Cobertura
    {
        public long CoberturaId { get; set; }

        [Required(ErrorMessage = "Informe o Nome da Cobertura")]
        [DisplayName("Nome da Cobertura")]
        public string Nome { get; set; }

        public virtual ICollection<Cadastro> Cadastros { get; set; }
    }
}

using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Cadastros
{
    public class Cadastro
    {
        public long? CadastroId { get; set; }
        [Required(ErrorMessage = "Informe o Nome do Plano")]
        [DisplayName("Nome do Plano")]
        public string Nome { get; set; }

        public long? CoberturaId { get; set; }
        public long? ClienteId { get; set; }

        [Required(ErrorMessage = "Informe o Nome da Cobertura")]
        [DisplayName("Cobertura")]
        public Cobertura Cobertura { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Cliente")]
        [DisplayName("Nome do Cliente")]
        public Cliente Cliente { get; set; }

    }
}
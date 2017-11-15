using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Cliente
    {
        [DisplayName("Id Cliente")]
        public long ClienteId { get; set; }

        [StringLength(100, ErrorMessage = "O nome do cliente precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome completo")]
        [DisplayName("Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("DDD")]
        public int DddTelefone { get; set; }

        [DisplayName("Telefone")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Informe o DDD")]
        [DisplayName("DDD")]
        public int DddCelular { get; set; }

        [Required(ErrorMessage = "Informe o Telefone Celular")]
        [DisplayName("Celular")]
        public int Celular { get; set; }

        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<Cadastro> Cadastros { get; set; }
    }
}
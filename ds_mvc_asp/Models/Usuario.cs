using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ds_mvc_asp.Models
{
    public class Usuario
    {
        [Display (Name = "Nome")]
        [Required (ErrorMessage = "O nome é obrigatório")]

        public string NomeUsuario { get; set;  }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        
        public string Nasc { get; set; }

        [Display (Name = "E-mail")]
        [RegularExpression (@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]

        public string Email { get; set; }

        [Display (Name = "Crie sua senha")]
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Senha obrigatória")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string Confsenha { get; set; }

    }
}
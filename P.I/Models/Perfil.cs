using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P.I.Models
{
    public class Perfil
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Nome_usuario { get; set; }
        public string Dt_nascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
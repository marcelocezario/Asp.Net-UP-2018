using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aula2205_Entity.Models
{
    public class Atividade
    {
        
        public int AtividadeID { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }
        
    }
}
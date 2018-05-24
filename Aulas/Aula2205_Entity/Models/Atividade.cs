using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2205_Entity.Models
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }


    }
}
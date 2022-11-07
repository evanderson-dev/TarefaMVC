using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarefaMVC.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }
    }
}
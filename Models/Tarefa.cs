using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoDIO.Models;
namespace TodoDIO.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
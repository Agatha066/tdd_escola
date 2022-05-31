using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Aluno(int id, string nome, string mat)
        {
            Id = id;
            Nome = nome;
            Matricula = mat;
        }

    }
}

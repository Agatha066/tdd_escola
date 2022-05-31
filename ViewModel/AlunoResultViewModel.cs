using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class AlunoResultViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataIngresso { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public string GetMat()
        {
            return Matricula;
        }
        public void SetMat(string mat)
        {
            Matricula = mat;
        }
    }
}

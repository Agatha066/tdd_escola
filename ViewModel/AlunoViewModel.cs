using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class AlunoViewModel
    {
        string Nome { get; set; }
        string Cpf { get; set; }
        DateTime DataNasc { get; set; }
        DateTime DataIngresso { get; set; }
        string Matricula { get; set; }
        string Curso { get; set; }
        string Endereco { get; set; }
        string Cep { get; set; }
        string Cidade { get; set; }
        string Uf { get; set; }
    }
}

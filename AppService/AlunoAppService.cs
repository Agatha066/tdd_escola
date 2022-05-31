using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.AppService
{
    public class AlunoAppService
    {
        private Aluno _aluno;
        IAlunoService _alunoService;

        public AlunoAppService()
        {
        }

        public AlunoAppService(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }
        public AlunoResultViewModel GetAluno(int id)
        {
            Aluno aluno = _alunoService.GetById(id);

            AlunoResultViewModel alunoVm = new AlunoResultViewModel();
            alunoVm.SetMat(aluno.Matricula);
            return alunoVm;
        }
    }
}

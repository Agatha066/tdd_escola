using AppCrud01.Application.AppService;
using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using Moq;
using System;
using Xunit;

namespace AppCrud01.Teste
{
    public class AlunoTest1
    {
        [Fact]
        public void TesteValidacaoAluno()
        {
            // Arrange
            int id = 1;
            Aluno aluno = new Aluno(1, "jose da silva", "123456");
            Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();
            mockAlunoService.Setup(m => m.GetById(1)).Returns(aluno);

            // Act
            AlunoAppService alunoAppService = new AlunoAppService(mockAlunoService.Object);
            AlunoResultViewModel alunoEsperado = alunoAppService.GetAluno(id);

            //Assert
            Assert.Equal("123456", alunoEsperado.GetMat());
        }
 
    }
}

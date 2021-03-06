using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC__BO.Models
{
    public interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
        void IncluirAluno(Aluno aluno);
        void AtualizarAluno(Aluno aluno);
        void DeletarAluno(int id);
    }
}

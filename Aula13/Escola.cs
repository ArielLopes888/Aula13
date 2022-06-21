using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    public class Escola
    {
        Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public void CadastrarAluno()
        {
            Matriculados.Add(1, new Aluno()
            {
                Matricula = 1234,
                Nome = "José",
                Sobrenome = "Silva",
                Telefone = 123456789,
            });
        }

        public void RemoverAluno()
        {
            Matriculados.Remove(123, "José");
        }
    }
}

//Cadastrar Aluno.
//Remover Aluno.
//Listar todas as Matrículas com Nomes de Alunos.
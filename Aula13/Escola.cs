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

        public void CadastrarAluno(int id, Aluno aluno)
        {
            Matriculados.Add(id, aluno);
        }

        public void RemoverAluno(int id)
        {
            
            id = Convert.ToInt32(Console.ReadLine());
            Matriculados.Remove(id);
        }

        public void Listar()
        {
            foreach (var item in Matriculados)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} {item.Value.Sobrenome}");
            }
        }
    }
}

//Cadastrar Aluno.
//Remover Aluno.
//Listar todas as Matrículas com Nomes de Alunos.
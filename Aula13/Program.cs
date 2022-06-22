namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escola = new Escola();
            int id = 0;
            do
            {
                var aluno1 = new Aluno();

                Console.WriteLine("Digite seu nome:");
                aluno1.Nome = Console.ReadLine();
                Console.WriteLine("Digite seu Sobrenome:");
                aluno1.Sobrenome = Console.ReadLine();

                escola.CadastrarAluno(id, aluno1);

                escola.Listar();

                id++;

            } while (true);
            
        }
    }
}
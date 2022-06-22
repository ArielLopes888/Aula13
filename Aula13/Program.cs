namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escola = new Escola();
            int id = 0;
            string escolha = "1";
            while (escolha == "1" || escolha == "2" || escolha == "3")
            {
                Console.WriteLine("Escolha uma operação: 1/Cadastrar  2/Remover  3/Listar");
                escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    var aluno_user = new Aluno();

                    Console.WriteLine("Digite seu nome:");
                    aluno_user.Nome = Console.ReadLine();
                    Console.WriteLine("Digite seu Sobrenome:");
                    aluno_user.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone:");
                    aluno_user.Telefone = Console.ReadLine();
                    Console.WriteLine(Environment.NewLine);

                    escola.CadastrarAluno(id, aluno_user);

                    id++;
                }
                else if(escolha == "2")
                {

                    escola.RemoverAluno(id);
                   
                }
                else if(escolha == "3")
                {
                    escola.Listar();
                    Console.WriteLine(Environment.NewLine);
                }
            
            }
            
            
        }
    }
}
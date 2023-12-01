namespace Principal
{
    internal class Program
    {
        static void Main()
        {
            // Array com os nomes dos exercícios
            string[] exercicios = {
                "Verificação de Número Par ou Ímpar",
                "Calculadora Simples",
                "Aprovação em uma Disciplina",
                "Identificação de Triângulos",
                "Manipulação de Strings",
                "Conversão de Tipos",
                "Cálculo de Área"
            };

            // Loop principal
            while (true)
            {
                // Exibe a lista de exercícios disponíveis
                MostrarListaExercicios(exercicios);

                // Obtém a escolha do usuário
                int escolha = ObterEscolhaUsuario(exercicios.Length);

                // Verifica se o usuário escolheu sair
                if (escolha == exercicios.Length + 1)
                {
                    Console.WriteLine("\nPrograma encerrado.");
                    break;
                }

                // Executa o programa correspondente à escolha do usuário
                ExecutarExercicio(escolha, exercicios);
            }
        }

        // Método para mostrar a lista de exercícios disponíveis
        static void MostrarListaExercicios(string[] exercicios)
        {
            Console.WriteLine("\nEscolha um exercício:");

            for (int i = 0; i < exercicios.Length; i++) Console.WriteLine($"{i + 1}. {exercicios[i]}");

            Console.WriteLine($"{exercicios.Length + 1}. Sair");
        }

        // Método para obter a escolha do usuário
        static int ObterEscolhaUsuario(int numeroExercicios)
        {
            int escolha;

            do
            {
                Console.Write("\nDigite o número do exercício desejado: ");
            } while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > numeroExercicios + 1);

            return escolha;
        }

        // Método para executar o programa correspondente à escolha do usuário
        static void ExecutarExercicio(int escolha, string[] exercicios)
        {
            Console.WriteLine($"\nExecutando Exercício {escolha}: {exercicios[escolha - 1]}\n");

            // Chama o método correspondente ao exercício escolhido
            switch (escolha)
            {
                case 1:
                    Exercício1.Program.Main();
                    break;
                case 2:
                    Exercício2.Program.Main();
                    break;
                case 3:
                    Exercício3.Program.Main();
                    break;
                case 4:
                    Exercício4.Program.Main();
                    break;
                case 5:
                    Exercício5.Program.Main();
                    break;
                case 6:
                    Exercício6.Program.Main();
                    break;
                case 7:
                    Exercício7.Program.Main();
                    break;
            }
        }
    }
}

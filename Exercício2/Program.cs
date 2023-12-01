namespace Exercício2
{
    public class Program
    {
        public static void Main()
        {
            // Solicita e obtém o primeiro número do usuário
            double numero1 = ObterNumero("Digite o primeiro número: ");

            // Solicita e obtém o segundo número do usuário
            double numero2 = ObterNumero("Digite o segundo número: ");

            // Exibe as opções de operação disponíveis
            MostrarOpcoesOperacao();

            // Obtém a escolha do usuário para a operação desejada
            int escolha = ObterEscolhaOperacao();

            // Realiza a operação com base na escolha do usuário e exibe o resultado
            RealizarOperacao(numero1, numero2, escolha);
        }

        // Função para obter um número válido do usuário
        static double ObterNumero(string mensagem)
        {
            double numero;

            do
            {
                Console.Write(mensagem);

                if (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }

            } while (!double.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        // Exibe as opções de operação disponíveis
        static void MostrarOpcoesOperacao()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
        }

        // Obtém a escolha do usuário para a operação desejada
        static int ObterEscolhaOperacao()
        {
            int escolha;

            do
            {
                Console.Write("Digite o número da operação desejada: ");
            } while (!int.TryParse(Console.ReadLine(), out escolha));

            return escolha;
        }

        // Realiza a operação com base na escolha do usuário e exibe o resultado
        static void RealizarOperacao(double numero1, double numero2, int escolha)
        {
            switch (escolha)
            {
                case 1:
                    MostrarResultado("Adição", numero1 + numero2);
                    break;
                case 2:
                    MostrarResultado("Subtração", numero1 - numero2);
                    break;
                case 3:
                    MostrarResultado("Multiplicação", numero1 * numero2);
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        MostrarResultado("Divisão", numero1 / numero2);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida.");
                    break;
            }
        }

        // Exibe o resultado da operação
        static void MostrarResultado(string operacao, double resultado)
        {
            Console.WriteLine($"Resultado da {operacao}: {resultado}");
        }
    }

}
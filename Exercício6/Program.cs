namespace Exercício6
{
    public class Program
    {
        public static void Main()
        {
            // Solicita ao usuário inserir um número decimal
            double numeroDecimal = ObterNumeroDecimal();

            // Converte o número para inteiro, double e float e exibe os resultados
            ConverterExibirResultados(numeroDecimal);
        }

        // Método para obter um número decimal do usuário
        static double ObterNumeroDecimal()
        {
            double numero;
            bool entradaValida;

            do
            {
                Console.Write("Digite um número decimal: ");
                entradaValida = double.TryParse(Console.ReadLine(), out numero);

                if (!entradaValida)
                {
                    Console.WriteLine("Por favor, digite um número decimal válido.");
                }

            } while (!entradaValida);

            return numero;
        }

        // Método para converter o número para inteiro, double e float e exibir os resultados
        static void ConverterExibirResultados(double numero)
        {
            // Converte o número para inteiro
            int numeroInteiro = (int)numero;

            // Converte o número para float
            float numeroFloat = (float)numero;

            // Exibe os resultados
            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine($"Convertido para inteiro: {numeroInteiro}");
            Console.WriteLine($"Convertido para float: {numeroFloat}");
        }
    }

}
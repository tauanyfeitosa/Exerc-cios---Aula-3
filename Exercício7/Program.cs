namespace Exercício7
{
    public class Program
    {
        public static void Main()
        {
            // Solicita ao usuário o raio do círculo
            double raio = ObterRaio();

            // Calcula a área do círculo e exibe o resultado
            CalcularEExibirAreaDoCirculo(raio);
        }

        // Método para obter o raio do usuário
        static double ObterRaio()
        {
            double raio;
            bool entradaValida;

            do
            {
                Console.Write("Digite o raio do círculo: ");
                entradaValida = double.TryParse(Console.ReadLine(), out raio);

                if (!entradaValida || raio <= 0)
                {
                    Console.WriteLine("Por favor, digite um raio válido maior que zero.");
                }

            } while (!entradaValida || raio <= 0);

            return raio;
        }

        // Método para calcular a área do círculo e exibir o resultado
        static void CalcularEExibirAreaDoCirculo(double raio)
        {
            // Calcula a área do círculo usando a fórmula A = π * r^2
            double area = Math.PI * Math.Pow(raio, 2);

            // Exibe o resultado
            Console.WriteLine($"A área do círculo com raio {raio} é: {area}");
        }
    }

}
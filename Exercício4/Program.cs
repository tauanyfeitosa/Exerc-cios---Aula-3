namespace Exercício4
{
    public class Program
    {
        public static void Main()
        {
            // Solicita os comprimentos dos lados do triângulo
            double lado1 = ObterComprimentoLado("Digite o comprimento do primeiro lado: ");
            double lado2 = ObterComprimentoLado("\nDigite o comprimento do segundo lado: ");
            double lado3 = ObterComprimentoLado("\nDigite o comprimento do terceiro lado: ");

            // Identifica o tipo de triângulo e exibe o resultado
            IdentificarTriangulo(lado1, lado2, lado3);
        }

        // Método para obter o comprimento de um lado do triângulo
        static double ObterComprimentoLado(string mensagem)
        {
            double comprimento;

            do
            {
                Console.Write(mensagem);

                if (!double.TryParse(Console.ReadLine(), out comprimento) || comprimento <= 0)
                {
                    Console.WriteLine("Por favor, digite um comprimento válido maior que zero.");
                }

            } while (!double.TryParse(Console.ReadLine(), out comprimento) || comprimento <= 0);

            return comprimento;
        }

        // Método para identificar o tipo de triângulo e exibir o resultado
        static void IdentificarTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("É um triângulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("É um triângulo isósceles.");
            }
            else
            {
                Console.WriteLine("É um triângulo escaleno.");
            }
        }
    }

}
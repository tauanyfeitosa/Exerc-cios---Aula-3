namespace Exercício1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nDigite um número inteiro:");

            // Tenta converter a entrada do usuário para um número inteiro
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Chama a função VerificarParOuImpar para verificar se o número é par ou ímpar
                VerificarParOuImpar(numero);
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
            }
        }

        static void VerificarParOuImpar(int num)
        {
            // Verifica se o número é par ou ímpar
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é um número par.");
            }
            else
            {
                Console.WriteLine($"{num} é um número ímpar.");
            }
        }
    }

}
namespace Exercício3
{
    public class Program
    {
        public static void Main()
        {
            // Solicita a nota do aluno
            double nota = ObterNota();

            // Verifica se o aluno foi aprovado ou reprovado
            VerificarAprovacao(nota);
        }

        // Método para obter a nota do aluno
        static double ObterNota()
        {
            double nota;

            do
            {
                Console.Write("Digite a nota do aluno: ");

                if (!double.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Por favor, digite uma nota válida.");
                }

            } while (!double.TryParse(Console.ReadLine(), out nota));

            return nota;
        }

        // Método para verificar se o aluno foi aprovado ou reprovado
        static void VerificarAprovacao(double nota)
        {

            // Verifica se a nota é maior ou igual à média de aprovação
            if (nota >= 7.0)
            {
                Console.WriteLine($"Parabéns! O aluno foi aprovado com nota {nota}.");
            }
            else
            {
                Console.WriteLine($"Infelizmente, o aluno foi reprovado com nota {nota}.");
            }
        }
    }

}
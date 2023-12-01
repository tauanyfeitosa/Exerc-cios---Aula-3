namespace Exercício5
{
    public class Program
    {
        public static void Main()
        {
            // Solicita ao usuário inserir seu nome completo
            string nomeCompleto = ObterNomeCompleto();

            // Exibe o nome em maiúsculas
            ExibirNomeMaiusculo(nomeCompleto);

            // Exibe o nome em minúsculas
            ExibirNomeMinusculo(nomeCompleto);

            // Exibe o comprimento do nome
            ExibirComprimentoNome(nomeCompleto);
        }

        // Método para obter o nome completo do usuário
        static string ObterNomeCompleto()
        {
            Console.Write("Digite seu nome completo: ");
            return Console.ReadLine();
        }

        // Método para exibir o nome em maiúsculas
        static void ExibirNomeMaiusculo(string nome)
        {
            Console.WriteLine($"Nome em maiúsculas: {nome.ToUpper()}");
        }

        // Método para exibir o nome em minúsculas
        static void ExibirNomeMinusculo(string nome)
        {
            Console.WriteLine($"Nome em minúsculas: {nome.ToLower()}");
        }

        // Método para exibir o comprimento do nome
        static void ExibirComprimentoNome(string nome)
        {
            Console.WriteLine($"O comprimento do nome é: {nome.Length} caracteres.");
        }
    }

}
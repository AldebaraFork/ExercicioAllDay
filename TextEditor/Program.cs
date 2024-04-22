using System.Net.Http.Headers;

namespace TextEditorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edicoes edicoes = new Edicoes();
            Console.WriteLine("Olá, bem vindo ao Editor de Texto, Escolha uma opção! ");
            Console.WriteLine("1 - Traduzir texto para maiúsculo. ");
            Console.WriteLine("2 - Traduzir texto para minúsculo. ");
            Console.WriteLine("3 - Verificar quantidade de caracteres. ");
            Console.WriteLine("4 - Verificar se existe uma palavra no texto. ");
            Console.WriteLine("5 - Substituir palavras no texto.");
            int OpcaoSelecionada = int.Parse(Console.ReadLine());
            switch (OpcaoSelecionada)
            {
                case 1:
                    edicoes.TextoMaiusculo();
                    break;
                case 2:
                    edicoes.TextoMinusculo();
                    break;
                case 3:
                    edicoes.QuantidadeCaracteres();
                    break;
                case 4:
                    edicoes.VerificarPalavra();
                    break;
                case 5:
                    edicoes.TrocarPalavra();
                    break;
            }

        }
    }
}
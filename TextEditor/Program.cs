using System.Net.Http.Headers;

namespace TextEditorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
                    TextoMaiusculo textinhoMai = new TextoMaiusculo();
                    textinhoMai.textoMaiusculo();
                    break;
                case 2:
                    TextoMinusculo textinhoMin = new TextoMinusculo();
                    textinhoMin.textoMinusculo();;
                    break;
                case 3:
                    Caracteres carac = new Caracteres();
                    carac.QuantidadeCaracteres();
                    break;
                case 4:
                    VerificarPalavras palavrinhas = new VerificarPalavras();
                    palavrinhas.VerificarPalavra();
                    break;
                case 5:
                    TrocarPalavraTexto tradepalavra = new TrocarPalavraTexto();
                    tradepalavra.TrocarPalavra();
                    break;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class Menu
    {
        public void Menuzada()
        {
            Console.WriteLine("Olá, bem vindo ao Editor de Texto, Escolha uma opção! ");
            Console.WriteLine("1 - Traduzir texto para maiúsculo. ");
            Console.WriteLine("2 - Traduzir texto para minúsculo. ");
            Console.WriteLine("3 - Verificar quantidade de caracteres. ");
            Console.WriteLine("4 - Verificar se existe uma palavra no texto. ");
            Console.WriteLine("5 - Substituir palavras no texto.");
            Console.WriteLine("6 - Adicionar palavras ao texto");
            Console.WriteLine("7 - Remover palavras do texto");
            Console.WriteLine("8 - Criar arquivo ");
            Console.WriteLine("9 - Abrir arquivo ");
            Console.WriteLine("0 - Sair");
            short OpcaoSelecionada = short.Parse(Console.ReadLine());
            switch (OpcaoSelecionada)
            {
                case 1:
                    Console.Clear();
                    TextoMaiusculo textinhoMai = new TextoMaiusculo();
                    textinhoMai.textoMaiusculo();

                    break;
                case 2:
                    Console.Clear();
                    TextoMinusculo textinhoMin = new TextoMinusculo();
                    textinhoMin.textoMinusculo();
                    break;
                case 3:
                    Console.Clear();
                    Caracteres carac = new Caracteres();
                    carac.QuantidadeCaracteres();
                    break;
                case 4:
                    Console.Clear();
                    VerificarPalavras palavrinhas = new VerificarPalavras();
                    palavrinhas.VerificarPalavra();
                    break;
                case 5:
                    Console.Clear();
                    TrocarPalavraTexto tradepalavra = new TrocarPalavraTexto();
                    tradepalavra.TrocarPalavra();
                    break;
                case 6:
                    Console.Clear();
                    AddRemove AddPalavra = new AddRemove();
                    AddPalavra.AdicionarPalavra();
                    break;
                case 7:
                    Console.Clear();
                    AddRemove removepalavra = new AddRemove();
                    removepalavra.RemoverPalavra();
                    break;
                case 8:
                    Console.Clear();
                    CriarArquivo criar = new CriarArquivo();
                    criar.CriarTexto();
                    break;
                case 9:
                    Console.Clear();
                    AbrirArquivo abrir = new AbrirArquivo();
                    abrir.Abrir();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Adeus! obrigado por usar meu app");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente");

                    break;
            }
        }
    }
}

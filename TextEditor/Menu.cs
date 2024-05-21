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
            Console.WriteLine("6 - Criar arquivo ");
            Console.WriteLine("7 - Abrir arquivo ");
            Console.WriteLine("8 - Sair");
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
                    EditarArquivo edit = new EditarArquivo();
                    edit.Editar();
                    break;
                case 7:
                    Console.Clear();
                    AbrirArquivo abrir = new AbrirArquivo();
                    abrir.Abrir();
                    break;
                case 8:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente");

                    break;
            }
        }
    }
}

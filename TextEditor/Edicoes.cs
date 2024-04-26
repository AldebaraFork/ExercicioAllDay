using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class Edicoes
    {
        public void TextoMaiusculo()
        {
            Console.WriteLine("Digite o texto que deseja traduzir para maiusculo: ");
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Texto traduzido para maiusculo: " + TextoInserido.ToUpper());
        }
        public void TextoMinusculo()
        {
            Console.WriteLine("Digite o texto que deseja traduzir para minúsculo: ");
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Texto traduzido para minúsculo: " + TextoInserido.ToLower());
        }
        public void QuantidadeCaracteres()
        {
            Console.WriteLine("Digite o texto para saber a quantidade de caracteres: ");
            string TextoInserido = Console.ReadLine();
            int QuantidadeTexto = TextoInserido.Length;
            Console.WriteLine("A quantidade de caracteres é: " + QuantidadeTexto);
        }
        public void VerificarPalavra()
        {
            Console.WriteLine("Você selecionou a opção Buscar uma palavra ou frase!");
            Console.WriteLine("Digite o texto para buscar a palavra: ");
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Por-favor digite a palavra ou frase que deseja buscar: ");
            string Buscada = Console.ReadLine();
            var PalavraBuscadas = Buscada.Contains(TextoInserido, StringComparison.OrdinalIgnoreCase);
            if (PalavraBuscadas == true)
            {
                Console.WriteLine("A palavra existe no texto inserido! ");
            }
            else
            {
                Console.WriteLine("A palavra nao existe no texto inserido!");
            }
        }
        public void TrocarPalavra()
        {
            Console.WriteLine("Você selecionou a opção trocar palavras!");
            Console.WriteLine("Digite o texto que deseja modificar: ");
            string TextoInserido = Console.ReadLine();
            Console.Write("Por-favor digite a palavra que deseja substituir: ");
            string PalavraSubstituida = Console.ReadLine();
            Console.Write("Por qual palavra voce deseja substiuir " + PalavraSubstituida + " por?  ");
            string PalavraSubstituta = Console.ReadLine();
            string TextoModificado = TextoInserido.Replace(PalavraSubstituida, PalavraSubstituta);
            Console.WriteLine(TextoModificado);
        }
        
        

       
    }
}

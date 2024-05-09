using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class VerificarPalavras
    {
         public void VerificarPalavra()
        {
            Console.WriteLine("Você selecionou a opção Buscar uma palavra ou frase!");
            Console.WriteLine("Digite o texto para buscar a palavra: ");
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Por-favor digite a palavra ou frase que deseja buscar: ");
            string Buscada = Console.ReadLine();
            var PalavraBuscadas = TextoInserido.Contains(Buscada, StringComparison.OrdinalIgnoreCase);
            if (PalavraBuscadas == true)
            {
                Console.WriteLine("A palavra existe no texto inserido! ");
            }
            else
            {
                Console.WriteLine("A palavra nao existe no texto inserido!");
            }
        }
    }
}

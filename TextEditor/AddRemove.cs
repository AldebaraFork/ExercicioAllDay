using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class AddRemove
    {
        public void AdicionarPalavra()
        {
            //texto
            Console.WriteLine("Por-favor escreva o texto que deseja adicionar uma palavra (Esc para sair)");
            string TextoInserido = null;
            do
            {
                TextoInserido += Console.ReadLine();
                TextoInserido += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Agora qual palavra voce gostaria de adicionar!");
            string PalavraInserida = Console.ReadLine();
            Console.WriteLine("Em qual posição?");
            int Posicao = int.Parse(Console.ReadLine());
            string TextoModificado = TextoInserido.Insert(Posicao, PalavraInserida);




            Console.WriteLine("Gerando texto......");
            Console.WriteLine($"Texto modificado: {TextoModificado}");
            Console.WriteLine("------------------------------------------");
            Thread.Sleep(4000);
            //salvando texto
            Console.WriteLine("Deseja salvar seu arquivo? S/N");
            char Salvar = char.Parse(Console.ReadLine().ToLower());
            if (Salvar == 's')
            {
                SalvarTexto salvarTexto = new SalvarTexto();
                salvarTexto.SalvarTextos(TextoModificado);
            }
            else if (Salvar == 'n')
            {
                Console.WriteLine("Obrigado por usar meu aplicativo! Adeus");
                Thread.Sleep(2500);
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção invalida! deseja sair ou retornar ao menu? SAIR/MENU");
                string Saida = Console.ReadLine().ToLower();
                if (Saida == "sair")
                {
                    Console.WriteLine("Saindo! obrigado por usar meu app");
                    Thread.Sleep(3500);
                    System.Environment.Exit(0);
                }
                else if (Saida == "menu")
                {
                    Console.WriteLine("Retornando ao menu principal!");
                    Thread.Sleep(3000);
                    Menu menu = new Menu();
                    menu.Menuzada();
                }
                else
                {
                    Console.WriteLine("Opção invalida! ");
                }
            }

        }
        public void RemoverPalavra()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto que deseja modificar! (Esc para sair) ");
            string TextoInserido = null;
            do
            {
                TextoInserido += Console.ReadLine();
                TextoInserido += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);


            Console.WriteLine("Agora digite a palavra que deseja remover no texto");
            string RemovePalavra = Console.ReadLine();
            string TextoModificado = TextoInserido.Replace(RemovePalavra, "");
            Console.Clear();

            Console.WriteLine("Texto modificado: " + TextoModificado);

            Console.WriteLine("Deseja salvar o texto? S/N");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's')
            {
                SalvarTexto salva = new SalvarTexto();
                salva.SalvarTextos(TextoModificado);
                Console.WriteLine("Arquivo salvo! obrigado por usar meu app, retornando ao menu... ");
                Thread.Sleep(3500);
                Menu menu = new Menu();
                menu.Menuzada();
            }
            else if (resposta == 'n')
            {
               
                Console.WriteLine("Deseja sair ou retornar ao menu? MENU/SAIR");
                string respostaSaida = Console.ReadLine();
                if (respostaSaida == "menu")
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Menuzada();
                }
                else if (respostaSaida == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do app...");
                    Thread.Sleep(2500);
                }

            }


        }

    }
}

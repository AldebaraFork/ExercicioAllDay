using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Multiplicar
    {
        public void CalcularMultiplicacao()
        {
            Console.WriteLine("Você selecionou a opção multiplicação! ");
            Console.Write("Digite o primeiro numero para multiplicar: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para multiplicar:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Resultado = Numer1 * Numer2;
            Console.WriteLine("A multiplicação de " + Numer1 + " * " + Numer2 + " é: " + Resultado);


        }


        public void SalvarArquivo(double Resultado)
        {
            Menu menu = new Menu();
            Console.WriteLine("Deseja salvar arquivo? S/N");
            var resposta = Console.ReadLine().ToLower();
            //SALVAR ARQUIVO
            if (resposta == "s" || resposta == "sim")
            {
                Console.Clear();
                Console.Write("Aonde deseja salvar o arquivo: ");
                var path = Console.ReadLine();
                using (var arquivo = new StreamWriter(path))
                {
                    arquivo.WriteLine(Resultado);
                }
                Console.WriteLine($"Arquivo salvo com sucesso em {path}");
                Console.WriteLine("Voltando ao menu principal");
                Thread.Sleep(3000);
                Console.Clear();
                menu.Menuzada();
            }
            //NAO SALVAR ARQUIVO
            else if (resposta == "n" || resposta == "nao")
            {
                Console.WriteLine("Arquivo não salvo! retornando ao menu principal....");
                Thread.Sleep(2000);
                Console.Clear();
                menu.Menuzada();
            }
            // VAZIO
            else if (string.IsNullOrEmpty(resposta))
            {
                Console.WriteLine("Por-favor digite algo! tente novamente");
                Thread.Sleep(2000);
                Console.Clear();
                SalvarArquivo(Resultado);
            }
            //RESPOSTA INCORRETA
            else
            {
                Console.WriteLine("Opção invalida! tente novamente");
                Thread.Sleep(2000);
                Console.Clear();
                SalvarArquivo(Resultado);
            }
        }
    }
}

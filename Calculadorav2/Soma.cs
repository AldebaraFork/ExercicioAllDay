using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculadoraV2
{
    internal class Soma
    {
        //SOMA 
        public void CalcularSoma()
        {
            //SOMAR 
            try
            {
                Menu menu = new Menu();

                Console.WriteLine("Você selecionou a opção soma! (use virgula) ");
                Console.Write("Digite o primeiro numero para soma: ");
                double Numer1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero para soma:");
                double Numer2 = double.Parse(Console.ReadLine());
                double Resultado = Numer1 + Numer2;
                Console.WriteLine("A soma de " + Numer1 + " + " + Numer2 + " é: " + Resultado.ToString(CultureInfo.CurrentCulture));


                //SALVAR-SOMA

                Console.WriteLine("Deseja salvar esse arquivo? S/N");
                var resposta = Console.ReadLine().ToLower();
                if (resposta == "s" || resposta == "sim")
                {
                    Console.Clear();
                    Console.WriteLine("Qual caminho deseja salvar o arquivo? ");
                    var path = Console.ReadLine();
                    using (var arquivo = new StreamWriter(path))
                    {
                        //salvando arquivo inserido no path
                        arquivo.WriteLine(Resultado);

                    }
                    Console.Clear();
                    Console.WriteLine($"Arquivo salvo com sucesso em {path}");
                    Console.WriteLine("Voltando ao menu principal");
                    Thread.Sleep(3000);
                    Console.Clear();

                    menu.Menuzada();
                }
                else if (resposta == "nao" || resposta == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Arquivo não salvo! retornando ao menu....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    menu.Menuzada();
                }
                else if (string.IsNullOrEmpty(resposta))
                {
                    Console.WriteLine("Por-favor insira um valor valido....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    CalcularSoma();
                }
            }
           
            catch (Exception exemplo)
            {
                Console.WriteLine(exemplo.InnerException);
                Console.WriteLine(exemplo.Message);
                Console.WriteLine("Aconteceu um erro inesperado.....");
            }
        }


    }
}

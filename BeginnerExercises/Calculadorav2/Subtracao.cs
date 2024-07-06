using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Subtracao
    {
        public void CalcularSubtracao()
        {
            Menu menu = new Menu();

            Console.WriteLine("Você selecionou a opção Subtração! Por-favor utilize virgula para numeros quebrados! ");
            Console.Write("Digite o primeiro numero para subtrair:");
            double Numer1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Digite o segundo numero para subtrair:");
            double Numer2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double Resultado = Numer1 - Numer2;
            Console.WriteLine("A subtração de " + Numer1 + " - " + Numer2 + " é: " + Resultado.ToString(CultureInfo.InvariantCulture));

            //SALVA A SUBTRAÇÃO 
            try
            {
                SalvarResultado(Resultado);
                Thread.Sleep(2000);
            }
            catch (Exception exemplo)
            {
                Console.WriteLine(exemplo.InnerException);
                Console.WriteLine(exemplo.Message);
                Console.WriteLine("Aconteceu um erro inesperado.....");
            }

            RetornarMenu();
        }
        //Salvar Subtração
        public void SalvarResultado(double Resultado)
        {
            Menu menu = new Menu();

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
                CalcularSubtracao();
            }
        }

        public void RetornarMenu()
        {
            try
            {
                Console.Clear();
                Menu menu = new Menu();
                Console.WriteLine("Deseja retornar ao menu ou sair? MENU/SAIR");
                string RespMenu = Console.ReadLine().ToLower();
                if (RespMenu == "menu")
                {
                    Console.Clear();
                    Console.WriteLine("Retornando ao menu principal.......");
                    Thread.Sleep(2000);
                    Console.Clear();
                    menu.Menuzada();
                }
                else if (RespMenu == "sair")
                {
                    Console.Clear();
                    Console.WriteLine("Saindo.....");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                }
                else if (string.IsNullOrEmpty(RespMenu))
                {
                    Console.WriteLine("Por-favor insira algum valor...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    RetornarMenu();
                }
                else
                {
                    Console.WriteLine("Opção invalida! retornando ao menu principal.....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    menu.Menuzada();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Algo deu errado");
            }
        }
    }
}

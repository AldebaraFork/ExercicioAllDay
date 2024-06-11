using System.Globalization;
using System.Numerics;

namespace ExercitandoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            VerificarNome();
            VerificarIdade();
            VerificarCPF();
        }

        //VERIFICAÇÃO DE NOME 
        static void VerificarNome()
        {
            People people = new People();
            Console.Write("Por-favor insira seu nome: ");
            people.name = Console.ReadLine();
            Console.WriteLine($"Bem vindo {people.name}! Por-favor agora insira seu aniversario:");
        }
        //VERIFICAÇÃO DE IDADE
        static void VerificarIdade()
        {
            try
            {
                People people = new People();
                people.date = DateTime.Parse(Console.ReadLine());
                if (people.date.Year >= 2006)
                {
                    Console.WriteLine($"Você nasceu em: {people.date.ToShortDateString()}");
                    
                }
                else if (people.date.Year < 2006)
                {
                    Console.WriteLine("Você é menor de 18 anos, infelizmente não pode prosseguir");
                }
                else if (string.IsNullOrEmpty(people.date.ToString()))
                {
                    Console.WriteLine("Por-favor insira um valor valido!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarIdade();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro:");
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
            }
        }

        //VERIFICAÇÃO DE CPF
        static void VerificarCPF()
        {

            People people = new People();
            try
            {
                Console.Write("Ótimo, agora por-favor digite seu CPF:");
                people.CPF = Console.ReadLine();
                if (people.CPF.Length > 11)
                {
                    Console.WriteLine("CPF invalido! insira a quantidade correta de caracteres!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarCPF();
                }
                else if (people.CPF.Length < 11)
                {
                    Console.WriteLine("CPF invalido! insira a quantidade correta de caracteres!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarCPF();
                }
                else
                {
                    Console.WriteLine("Obrigado por inserir seu cpf! indo ao menu principal...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    //menu principal
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }

        }

        //PESSOA 
        public class People()
        {
            public string name { get; set; }

            public DateTime date { get; set; }
            public string CPF { get; set; }
        }

    }
}

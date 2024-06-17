using System.Globalization;
using System.Numerics;

namespace ExercitandoOOP
{
    internal class Program
    {
        //CLASSE PRINCIPAL 
        static void Main(string[] args)
        {
            //INICIO DO PROGRAMA
            People people = new People();
            people.VerificarNome();

        }
    }

    //DADOS DA PESSOA E METODOS
    public class People()
    {

        //PROPRIEDADES
        protected string name { get; set; }

        protected DateTime date { get; set; }
        protected string CPF { get; set; }





        //VERIFICAÇÃO DE NOME 
        public void VerificarNome()
        {
            People people = new People();
            Console.WriteLine("Por-favor insira seu nome: ");
            people.name = Console.ReadLine();
            if (people.name != string.Empty)
            {
                Console.Clear();
                Console.WriteLine($"Bem vindo {people.name}! Por-favor agora insira seu aniversario:");
                Thread.Sleep(2000);
                VerificarIdade();
            }
            else if (string.IsNullOrEmpty(people.name))
            {
                Console.WriteLine("Por-favor insira um valor valido! ");
                Thread.Sleep(2000);
                Console.Clear();
                VerificarNome();
            }
            else
            {
                Console.WriteLine("Ocorreu um erro......");
                Thread.Sleep(2000);
                Console.Clear();
                VerificarNome();
            }
        }
        //VERIFICAÇÃO DE IDADE
        static void VerificarIdade()
        {
            try
            {
                People people = new People();
                people.date = DateTime.Parse(Console.ReadLine());
                var Data = DateTime.Now.Year - people.date.Year;
                //MAIOR DE 18 ANOS
                if (Data >= 18)
                {
                    Console.WriteLine($"Ótimo pode prosseguir! Você tem {Data} anos");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarCPF();
                }
                //MENOR DE 18 ANOS
                else if (Data < 18)
                {
                    Console.WriteLine("Você é menor de 18 anos, infelizmente não pode prosseguir");
                    System.Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Insira um valor valido! ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarIdade();
                }
            }
            //ERRO   
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
            MenuPrincipal menuzada = new MenuPrincipal();
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
                    menuzada.MainMenu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro:");
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
            }

        }
    }



    //OPÇOES E MENU PRINCIPAL
    class MenuPrincipal 
    {

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine($"Olá , bem vindo ao menu principal! O que gostaria de fazer?");
            Console.WriteLine("1 - Cadastrar Funcionario");
            Console.WriteLine("2 - OpçãoAleatoria");
            Console.WriteLine("3 - OpçãoAleatoria");
            Console.WriteLine("4 - OpçãoAleatoria");
            Console.WriteLine("0 - sair");
            short Option = short.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Funcionario funcionario = new Funcionario();
                    funcionario.CargoFuncionario();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    Console.WriteLine("Saindo! Obrigado por usar meu app...");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida ! retornando ao menu....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
    }


    //FUNCIONARIO 
    class Funcionario : People
    {
        protected Guid IdFuncionario = Guid.NewGuid();
        string Cargo { get; set; }

        public void CargoFuncionario()
        {
            Console.Clear();
            Console.WriteLine($"Olá {name}, seu ID é: {IdFuncionario}");

        }
    }
}

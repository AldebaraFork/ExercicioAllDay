using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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
    public class People
    {

        //PROPRIEDADES
        protected string Name { get; set; }

        protected DateTime Date { get; set; }
        protected string CPF { get; set; }





        //VERIFICAÇÃO DE NOME 
        public void VerificarNome()
        {

            Console.Write("Por-favor insira seu nome: ");
            this.Name = Console.ReadLine();
            if (!string.IsNullOrEmpty(this.Name))
            {
                Console.Clear();
                Console.WriteLine($"Bem vindo {this.Name}! Por-favor agora insira seu aniversario:");
                Thread.Sleep(2000);
                VerificarIdade();
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
        public void VerificarIdade()
        {
            try
            {

                this.Date = DateTime.Parse(Console.ReadLine());
                var Data = DateTime.Now.Year - this.Date.Year;
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
        public void VerificarCPF()
        {


            MenuPrincipal menuzada = new MenuPrincipal();
            try
            {
                Console.Write("Ótimo, agora por-favor digite seu CPF:");
                this.CPF = Console.ReadLine();
                if (this.CPF.Length > 11)
                {
                    Console.WriteLine("CPF invalido! insira a quantidade correta de caracteres!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    VerificarCPF();
                }
                else if (this.CPF.Length < 11)
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
    public class MenuPrincipal : People
    {
        public void MainMenu()
        {            
            Console.Clear();
            Console.WriteLine($"Olá {base.Name}, bem vindo ao menu principal! O que gostaria de fazer?");
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
    public class Funcionario : People
    {
        protected Guid IdFuncionario = Guid.NewGuid();
        public string cargo = "funcionario";


        //CARGO DO FUNCIONARIO
        public void CargoFuncionario()
        {

            Console.Clear();
            Console.WriteLine($"Olá {Name}, seu ID é: {IdFuncionario}");
            Console.WriteLine($"Seu cargo atual é: {cargo}");

        }
    }




}

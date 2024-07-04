using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace CadastrarClienteOOP
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu men = new Menu();
            men.MenuPrincipal();
        }
    }
    public class Menu
    {
        //MENU PRINCIPAL
        public void MenuPrincipal()
        {
            GerenciarClientes gerencia = new GerenciarClientes();
            Console.Clear();
            Console.WriteLine("Digite o numero da opção: ");
            Console.WriteLine("1 - Cadastrar Clientes");
            Console.WriteLine("2 - Visualizar Clientes");
            Console.WriteLine("3 - Editar Clientes");
            Console.WriteLine("4 - Excluir Clientes");
            Console.WriteLine("0 - Sair");
            short opcaoMenu = short.Parse(Console.ReadLine());
            switch (opcaoMenu)
            {
                case 1:
                    gerencia.ObterDadosCliente();
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                //SAIR DO APP
                case 0:
                    Console.WriteLine("Saindo do app! Obrigado por usar! ");
                    System.Environment.Exit(0);
                    break;
                //OPÇÃO INVALIDA
                default:
                    RetornarMenu();
                    break;

            }
        }
        //RETORNAR AO MENU
        public void RetornarMenu()
        {
            Console.Clear();
            Console.WriteLine("Retornando ao menu....");
            Thread.Sleep(2000);
            MenuPrincipal();
        }
    }

    public class GerenciarClientes
    {
        Menu principal = new Menu();


        protected string NomeUsuario { get; set; }
        protected string EmailUsuario { get; set; }

        protected short IdadeUsuario { get; set; }

        //OBTER DADOS DO CLIENTE
        public void ObterDadosCliente()
        {

            Console.Clear();

            //OBTER NOME DO CLIENTE
            Console.Write("Insira o nome do usuario: ");
            NomeUsuario = Console.ReadLine();

            //CASO O USUARIO NAO INSIRA UM VALOR
            if (string.IsNullOrEmpty(NomeUsuario))
            {
                Console.WriteLine("Por-favor insira um valor valido! ");
                Thread.Sleep(2000);
                Console.Clear();
                ObterDadosCliente();
            }
            //NOME VALIDO
            else
            {
                Console.Write("Agora insira o email: ");
                EmailUsuario = Console.ReadLine();
                if (string.IsNullOrEmpty(EmailUsuario))
                {
                    Console.WriteLine("Insira um email valido! ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ObterDadosCliente();
                }

            }


            //OBTER IDADE DO CLIENTE

            Console.Write("Agora insira a idade: ");
            IdadeUsuario = short.Parse(Console.ReadLine());
            try
            {
                //CASO O USUARIO SEJA DE MENOR
                if (IdadeUsuario < 18)
                {
                   
                    Console.WriteLine("Você ainda é menor de idade.");
                    Thread.Sleep(2000);
                    principal.RetornarMenu();
                }
                 //CASO O USUARIO SEJA DE MAIOR , PROSSEGUIR
                else if (IdadeUsuario >= 18)
                {
                  
                    Console.WriteLine($"Cliente {NomeUsuario}  cadastrado com sucesso! ");
                    Thread.Sleep(2000);
                    principal.RetornarMenu();

                }
            }
            //CASO APRESENTE ERRO OU VALOR INVALIDO
            catch (FormatException ex)
            {
                Console.WriteLine("Insira um valor valido");
                Console.WriteLine(ex.Message);

            }
        }


    }

}







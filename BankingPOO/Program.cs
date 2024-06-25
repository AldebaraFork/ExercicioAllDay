using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace BankingPOO
{ //CLASSE PRINCIPAL
    internal class Program
    {
        //METODO PRINCIPAL
        static void Main(string[] args)
        {

           DadosUsuario dadosIniciais = new DadosUsuario();
            dadosIniciais.ObterDadosUsuario();

        }

    }

    //COMO USAR O GET E SET
    public class DadosUsuario()
    {
        //DADOS USUÁRIO
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public short Idade { get; set; }

        //OBTEM OS DADOS DO USUARIO
        public void ObterDadosUsuario()
        {
            Console.Write("Por-favor insira seu nome:");
            Nome = Console.ReadLine().ToLower();
            Console.Write($"Bem vindo {Nome}, agora insira seu Cpf: ");
            Cpf = Console.ReadLine();
            Console.Write($"Agora insira sua idade: ");
            Idade = short.Parse(Console.ReadLine());
            //IDADE INVALIDA
            if (Idade < 18)
            {
                Console.Clear();
                Console.WriteLine($"{Nome} , você ainda é menor de idade! não pode prosseguir");

            }
            //IDADE VALIDA - SEGUIR PARA MENU
            else if (Idade >= 18)
            {
                Console.WriteLine("Dados salvos ! indo ao menu principal....");
                Thread.Sleep(2000);
                Console.Clear();
                Menu men = new Menu();
                men.Menuzada();
            }
            else
            {
                Console.WriteLine("Valor invalido! tente novamente...");
                Thread.Sleep(2000);
                Console.Clear();
                ObterDadosUsuario();
            }
         
        }




    }
    //PAGAMENTO CARTAO
    public class PagamentoCartao : DadosUsuario
    {
        //DADOS CARTAO
        public string NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public DateTime ValidadeCartao { get; set; }

        public string CodigoSeguranca { get; set; }

        public DateTime Vencimento { get; set; }

        //PAGAMENTO CARTAO

        public void PagarComCartao()
        {
            Console.Write("Por-favor insira os numeros no cartão: ");
            NumeroCartao = Console.ReadLine();
            Console.Write("Agora insira o nome impresso no cartão: ");
            NomeCartao = Console.ReadLine().ToUpper();
            Console.Write("Insira o Codigo de segurança atrás do cartão: ");


            //VALIDAÇÃO CVV
            CodigoSeguranca = Console.ReadLine();
            //VALIDAÇÃO CORRETA
            if (CodigoSeguranca.Length == 3 || CodigoSeguranca.Length == 4)
            {
                Console.WriteLine("Valor invalido!");
                Thread.Sleep(2000);
                Console.Clear();
                PagarComCartao();


            }
            //VALIDAÇÃO ERRADA
            else
            {
                Console.WriteLine("Valor invalido!");
                Thread.Sleep(2000);
                Console.Clear();
                PagarComCartao();
            }

        }
    }



    //PAGAMENTO BOLETO
    public class PagamentoBoleto : DadosUsuario
    {

        public DateTime Vencimento { get; set; }

        public Random NumeroBoleto { get; set; }

        public double ValorBoleto { get; set; }

        public void PagarBoleto()
        {
            NumeroBoleto = new Random(1000000000);
            Console.WriteLine($"Codigo de pagamento  boleto: {NumeroBoleto}");
        }



    }

    //MENU E RETORNAR AO MENU
    public class Menu
    {

        public void Menuzada()
        {
            DadosUsuario dados = new DadosUsuario();
            PagamentoCartao cartao = new PagamentoCartao();
            PagamentoBoleto boleto = new PagamentoBoleto();

            Console.WriteLine("Bem vindo ao sistema de banco! Insira um numero para cada opção abaixo.");
            Console.WriteLine("1 - Pagamento com cartão");
            Console.WriteLine("2 - Pagamento com boleto");
            Console.WriteLine("3 - Pagamento com pix");
           
            Console.WriteLine("0 - Sair");
            short OpcaoSelecionada = short.Parse(Console.ReadLine());
            switch (OpcaoSelecionada)
            {
                //SAIR DO APP
                case 0:
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar meu app! saindo....");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);

                    break;
                //PAGAMENTO COM CARTAO
                case 1:
                    Console.Clear();
                    cartao.PagarComCartao();
                    break;
                //PAGAMENTO COM BOLETO
                case 2:
                    Console.Clear();
                    boleto.PagarBoleto();
                    break;
                //PAGAMENTO COM PIX
                case 3:
                    break;
                default:
                    Console.WriteLine("Opção invalida! tente novamente....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Menuzada();
                    break;


            }
        }
        //METODO PARA RETORNAR AO MENU FACILMENTE
        public void RetornarAoMenu()
        {
            Console.Clear();
            Console.WriteLine("Deseja retornar ao menu ou sair do app? MENU/SAIR");
            string RetornoMenu = Console.ReadLine().ToLower();
            if (RetornoMenu == "menu")
            {
                Console.WriteLine("Retornando ao menu principal....");
                Thread.Sleep(2000);
                Console.Clear();
                Menuzada();
            }else if (RetornoMenu == "sair")
            {
                Console.WriteLine("Obrigado por usar meu app! saindo...");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção invalida tente novamente! ");
                Thread.Sleep(2000);
                
                RetornarAoMenu();
            }



        }
    }
}


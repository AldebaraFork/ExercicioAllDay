using System;
using System.Data.SqlTypes;
using System.Globalization;
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
        protected string Nome { get; set; }
        private string Cpf { get; set; }
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
        private string NumeroCartao { get; set; }
        private string NomeCartao { get; set; }


        private string CodigoSeguranca { get; set; }

        public double Valor { get; set; }

        //PAGAMENTO CARTAO

        public void PagarComCartao()
        {
            //DADOS CARTÃO
            SalvarPagamentos salva = new SalvarPagamentos();
            Menu menu = new Menu();
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
                //VALIDAÇÃO CREDITO OU DEBITO
                Console.Clear();
                Console.WriteLine("Dados do cartão salvo! Débito ou Crédito? (DEBITO/CREDITO)");
                var DebitoOuCredito = Console.ReadLine().ToLower();
                //DEBITO
                if (DebitoOuCredito == "debito")
                {
                    Console.WriteLine("Qual o valor do pagamento?");
                    Valor = double.Parse(Console.ReadLine().ToString(CultureInfo.CurrentCulture));
                    Thread.Sleep(2000);
                    Console.WriteLine($"Pagamento realizado no valor de R$:{Valor} na função DEBITO");
                    Thread.Sleep(4000);
                    Console.Clear();

                    //SALVAR ARQUIVO DE PAGAMENTO
                    salva.SalvarValor(Valor);
                }
                //CREDITO
                else if (DebitoOuCredito == "credito")
                {
                    Console.WriteLine("Qual o valor do pagamento?");
                    Valor = double.Parse(Console.ReadLine().ToString(CultureInfo.CurrentCulture));
                    Thread.Sleep(2000);
                    Console.WriteLine($"Pagamento realizado no valor de R$:{Valor} na função CREDITO");
                    Thread.Sleep(4000);

                    //SALVAR ARQUIVO DE PAGAMENTO
                    salva.SalvarValor(Valor);
                }
                else
                {
                    Console.WriteLine("Opção incorreta! escreva uma opção valida!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    PagarComCartao();
                    Thread.Sleep(2000);
                }

            }
            //VALIDAÇÃO ERRADA
            else
            {
                Console.WriteLine("Valor invalido!");
                Thread.Sleep(2000);
                Console.Clear();
                PagarComCartao();
                Thread.Sleep(2000);
            }

            //RETORNA AO MENU PRINCIPAL OU SAI

            menu.RetornarAoMenu();
        }
    }



    //PAGAMENTO BOLETO
    public class PagamentoBoleto : DadosUsuario
    {


        public DateTime Vencimento { get; set; }



        public double Valor { get; set; }

        //PAGA O BOLETO
        public void PagarBoleto()
        {
            Menu menu = new Menu();
            SalvarPagamentos salvar = new SalvarPagamentos();
            //VALOR DO BOLETO
            Console.WriteLine("Qual o valor de pagamento do boleto?");
            Valor = double.Parse(Console.ReadLine());

            //CODIGO BOLETO
            string codigoBoleto = GerarCodigoBoleto();
            Console.WriteLine($"Codigo de pagamento  boleto: {codigoBoleto}");
            Console.WriteLine("Pressione ENTER quando realizar o pagamento!");
            var ContinuarPagamentoBoleto = Console.ReadKey().Key != ConsoleKey.Enter;

            Console.WriteLine("Pagando......");
            Thread.Sleep(5000);
            Console.WriteLine($"Pagamento realizado com sucesso! no valor de R${Valor}");
            Thread.Sleep(2000);
            salvar.SalvarValor(Valor);
            //VOLTA AO MENU
            menu.RetornarAoMenu();

        }

        //Gera o codigo do boleto
        static string GerarCodigoBoleto()
        {
            Random random = new Random();
            // Gera um número aleatório com 44 dígitos, que é o tamanho padrão de um código de boleto
            string codigo = "";
            for (int i = 0; i < 44; i++)
            {
                codigo += random.Next(0, 10).ToString();
            }
            return codigo;
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
            }
            else if (RetornoMenu == "sair")
            {
                Console.WriteLine("Obrigado por usar meu app! saindo...");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção invalida tente novamente! ");
                Thread.Sleep(2000);
                Console.Clear();
                RetornarAoMenu();
            }



        }
    }

    //SALVAR ARQUIVO
    public class SalvarPagamentos
    {
        Menu menu = new Menu();
        public void SalvarValor(double Valor)
        {
            Console.WriteLine("Deseja salvar o arquivo ? SIM/NAO");
            var resposta = Console.ReadLine().ToLower();
            if (resposta == "sim" || resposta == "s")
            {
                Console.Clear();
                Console.WriteLine("Qual caminho deseja salvar o arquivo? ");
                var path = Console.ReadLine();
                using (var arquivo = new StreamWriter(path))
                {
                    //salvando arquivo o texto inserido no path
                    arquivo.WriteLine("Valor do pagamento: " + Valor);

                }
                Console.Clear();
                Console.WriteLine($"Arquivo salvo com sucesso em {path}");
                Console.WriteLine("Voltando ao menu principal");
                Thread.Sleep(3500);
                Console.Clear();
                menu.Menuzada();
            }
            else if (resposta == "nao" || resposta == "n")
            {
                Console.WriteLine("Arquivo não salvo! ");
                Console.WriteLine("Voltando ao menu principal");
                Thread.Sleep(3500);
                Console.Clear();
                menu.Menuzada();
            }
            else
            {
                Console.WriteLine("Opção invalida! tente novamente");
                SalvarValor(Valor);
            }
        }
    }

}


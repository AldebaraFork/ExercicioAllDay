using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class VerificarAulas
    {
        public void Aulas()
        {
            Console.Clear();
            Console.WriteLine("Informe seu cargo:");
            Console.WriteLine("1 - Aluno");
            Console.WriteLine("2 - Professor");
            Console.WriteLine("0 - Retornar ao menu");

            short cargo = short.Parse(Console.ReadLine());
            switch (cargo)
            {
                case 1:
                    AulasAluno('A', 5);
                    break;
                case 2:
                    AulasProfessor('P', 7);
                    break;
                case 0:
                    SchoolSystem scc = new SchoolSystem();
                    Console.Clear();
                    Console.WriteLine("Retornando ao menu...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    scc.Menu();
                    break;
                default:
                    SchoolSystem scca = new SchoolSystem();
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    Thread.Sleep(2000);
                    Console.Clear();
                    scca.Menu();

                    break;
            }


        }
        public void AulasAluno(char primeiroCaractere, int comprimento)
        {

            Console.Clear();
            SchoolSystem scola = new SchoolSystem();
            Console.WriteLine($"Olá! gerando seu ID...");
            Thread.Sleep(2500);
            Console.Clear();
            var guid = Guid.NewGuid().ToString("N");
            var IdAluno = primeiroCaractere + guid.Substring(1, comprimento - 1);
            Console.Clear();
            Console.WriteLine($"ID gerado! Seu id é: {IdAluno} ,Por-favor anote esse numero");
            Console.Write("Por-favor digite seu ID: ");
            string idAluno = Console.ReadLine().ToUpper();
            Console.WriteLine("verificando ID....");
            Thread.Sleep(2000);

            if (idAluno.StartsWith("A"))
            {
                // Exiba as aulas dos alunos aqui
                Console.Clear();
                Console.WriteLine("Exibindo aulas para o aluno com ID: " + idAluno);
                Console.WriteLine("12:30 - Historia");
                Console.WriteLine("13:30 - Matematica");
                Console.WriteLine("intervalo");
                Console.WriteLine("14:00 - Geografia");
                Console.WriteLine("15:30 - Ciencias");
                Console.WriteLine("16:30 - Psicologia");
                Console.WriteLine("café da tarde");
                Console.WriteLine("17:00 - fisica");
                Console.WriteLine("18:30 - biologia");
                Console.WriteLine("Janta");
                Console.WriteLine("19:30 - quimica");
                Console.WriteLine("20:30 - ingles");
            }
            else
            {
                Console.WriteLine("ID invalido! retornando ao menu...");
                Thread.Sleep(2500);
                scola.Menu();
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Deseja retornar ao menu ou sair? MENU/SAIR");
            var resposta = Console.ReadLine().ToLower();
            if (resposta == "menu")
            {
                Console.Clear();
                Console.WriteLine("Retornando ao menu....");
                Console.Clear();
                Thread.Sleep(2000);
                scola.Menu();
            }
            else if (resposta == "sair")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o app!");
                System.Environment.Exit(0);
            }

        }
        public void AulasProfessor(char primeiroCaractere, int comprimento)
        {
            Console.Clear();
            SchoolSystem scuela = new SchoolSystem();
            Console.WriteLine("Gerando seu ID....");
            Thread.Sleep(2000);
            var guidao = Guid.NewGuid().ToString("N");
            var IdProfessor = primeiroCaractere + guidao.Substring(1, comprimento - 1);
            Console.WriteLine($"ID gerado: {IdProfessor} , Por-favor insira seu ID abaixo");
            var VerificarId = Console.ReadLine().ToUpper();
            if (VerificarId.StartsWith("P"))
            {
                Console.Clear();
                Console.WriteLine($"Exibindo aulas para o professor com ID: {IdProfessor}");
                Console.WriteLine("12:30 - 13:30 Matemática 1B");
                Console.WriteLine("intervalo");
                Console.WriteLine("14:00 - 15:30 Física");
                Console.WriteLine("15:30 - 16:30 Álgebra ");
                Console.WriteLine("café da tarde");
                Console.WriteLine("17:00 - 18:30 Matemática");
                Console.WriteLine("Janta");
                Console.WriteLine("19:30 - 20:30 quimica");
                Console.WriteLine("20:30 - Saida");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("ID invalido! retornando ao menu...");
                Thread.Sleep(2000);
                Console.Clear();
                scuela.Menu();
            }
            Console.WriteLine("================================================");
            Console.WriteLine("Deseja retornar ao menu ou sair? MENU/SAIR");
            var RespostaSaida = Console.ReadLine().ToLower();
            if (RespostaSaida == "sair")
            {
                Console.Clear();
                Console.WriteLine("Saindo do app....");
                System.Environment.Exit(0);


            }
            else if (RespostaSaida == "menu")
            {
                Console.Clear();
                Console.WriteLine("Voltando ao menu....");
                Thread.Sleep(2000);
                Console.Clear();
                scuela.Menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção invalida! retornando ao menu...");
                Thread.Sleep(2000);
                Console.Clear();
                scuela.Menu();
            }
        }

    }
}

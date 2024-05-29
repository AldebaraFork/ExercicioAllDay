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
            Console.WriteLine("Informe seu cargo:");
            Console.WriteLine("1 - Aluno");
            Console.WriteLine("2 - Professor");
            Console.WriteLine("3 - Diretoria");
            Console.WriteLine("0 - Retornar ao menu");
            short cargo = short.Parse(Console.ReadLine());
            switch (cargo)
            {
                case 1:
                    AulasAluno('A', 5);
                    break;

            }


        }
        public void AulasAluno(char primeiroCaractere, int comprimento)
        {

            Console.Clear();
            Console.WriteLine("Por-favor insira seu nome:");
            var NomeAluno = Console.ReadLine();
            Console.WriteLine($"Olá! {NomeAluno}, gerando seu ID...");
            Thread.Sleep(2500);
            Console.Clear();
            var guid = Guid.NewGuid().ToString("N");
            var IdAluno = primeiroCaractere + guid.Substring(1, comprimento - 1);
            Console.Clear();
            Console.WriteLine($"{NomeAluno} ID gerado! Seu id é: {IdAluno} ,Por-favor anote esse numero");
            Console.Write("Por-favor digite seu ID: ");
            string idAluno = Console.ReadLine().ToUpper();

            if (idAluno.StartsWith("A"))
            {
                // Exiba as aulas dos alunos aqui
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
                AulasAluno(primeiroCaractere, comprimento);
            }


        }
        public void AulasProfessor(char primeiroCaractere, int comprimento)
        {

        }

    }
}

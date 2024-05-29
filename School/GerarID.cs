using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class GerarID
    {
        public void gerarID()
        {
            Console.Clear();
            SalvarArquivo salvas = new SalvarArquivo();
            SchoolSystem schoolSystem = new SchoolSystem();
            Console.WriteLine("Olá, aqui iremos gerar seu ID (identificação)");
            Console.WriteLine("Por-favor digite seu cargo: ");
            Console.WriteLine("1 - Aluno");
            Console.WriteLine("2 - Professor");
            Console.WriteLine("3 - Diretoria");
            Console.WriteLine("0 - retornar ao menu");
            var cargo = short.Parse(Console.ReadLine());

            switch (cargo)
            {
                //metodo aluno
                case 1:
                    Console.Clear();
                    GerarIdEspecificoAluno('A', 5);
                    break;
                    //metodo professor
                case 2:
                    Console.Clear();
                    GerarIdEspecificoProfessor('P', 7);
                    break;
                    //metodo diretoria
                case 3:
                    Console.Clear();
                    GerarIdEspecificoDiretor('D', 9);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Voltando ao menu principal...");
                    Thread.Sleep(2500);
                    schoolSystem.Menu();
                    break;
                default:
                    Console.WriteLine("Opção invalida! retornando ao menu de Id...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    gerarID();
                    break;
            }
        }
        //GERA ID ALUNO
        public void GerarIdEspecificoAluno(char primeiroCaractere, int comprimento)
        {
            SalvarArquivo salvas = new SalvarArquivo();
            SchoolSystem schoolSystem = new SchoolSystem();
            Console.Clear();
            Console.WriteLine("Por-favor insira seu nome:");
            var NomeAluno = Console.ReadLine();
            Console.WriteLine($"Olá! {NomeAluno}, gerando seu ID...");
            Thread.Sleep(2500);
            Console.Clear();
            var guid = Guid.NewGuid().ToString("N");
            var IdAluno = primeiroCaractere + guid.Substring(1, comprimento - 1);
            Console.WriteLine($"{NomeAluno} ID gerado! Seu id é: {IdAluno} ,Por-favor anote esse numero");
            salvas.Salvar(IdAluno);
            
        }
        //GERA ID PROFESSOR
        public void GerarIdEspecificoProfessor(char primeiroCaractere, int comprimento)
        {
            SalvarArquivo salvas = new SalvarArquivo();
            SchoolSystem schoolSystem = new SchoolSystem();
            Console.Clear();
            Console.WriteLine("Por-favor insira seu nome:");
            var NomeProfessor = Console.ReadLine();
            Console.WriteLine($"Olá! {NomeProfessor}, gerando seu ID...");
            Thread.Sleep(2500);
            Console.Clear();
            var guid = Guid.NewGuid().ToString("N");
            var IdProfessor = primeiroCaractere + guid.Substring(1, comprimento - 1);
            Console.WriteLine($"{NomeProfessor} ID gerado! Seu id é: {IdProfessor} ,Por-favor anote esse numero");
            salvas.Salvar(IdProfessor);
        }
        //GERA ID DIRETOR
        public void GerarIdEspecificoDiretor(char primeiroCaractere, int comprimento)
        {
            SalvarArquivo salvas = new SalvarArquivo();
            SchoolSystem schoolSystem = new SchoolSystem();
            Console.Clear();
            Console.WriteLine("Por-favor insira seu nome:");
            var NomeDiretor = Console.ReadLine();
            Console.WriteLine($"Olá! {NomeDiretor}, gerando seu ID...");
            Thread.Sleep(2500);
            Console.Clear();
            var guid = Guid.NewGuid().ToString("N");
            var IdDiretor = primeiroCaractere + guid.Substring(1, comprimento - 1);
            Console.WriteLine($"{NomeDiretor} ID gerado! Seu id é: {IdDiretor} ,Por-favor anote esse numero");
            salvas.Salvar(IdDiretor);
        }
    }
}


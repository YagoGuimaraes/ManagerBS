using Exercicio2___FINAL.DAL;
using Exercicio2___FINAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio2___FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string escolha;

            while (a == 0)
            {
                Console.WriteLine("******************************************\nEscolha uma opção: ");
                Console.WriteLine("1) Cadastrar Aluno\n2) Alterar Aluno\n3) Deletar Aluno \n4) Imprimir listagem de produtos\n5) Sair do programa ");
                Console.WriteLine("******************************************");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        IncluirAluno();
                        break;
                    case "2":
                        DeletarAluno();
                        break;
                    case "5":
                        a++;
                        break;                        
                    default:
                        Console.WriteLine("Escolha não existente;");
                        break;
                }
            }
                IncluirAluno();
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();
        }

        private static void DeletarAluno()
        {

            using (var db = new AlunosContext())
            {
                int p1 = 100;

                var p2 = (from x in db.Alunos where x.Matricula == p1 select x).FirstOrDefault();

                if (p2 == null)
                    Console.WriteLine("Produto de id='Produto2' não encontrado.");
                else
                {
                    p2.Nome = "TESTE YAGO 123";
                    db.SaveChanges();
                }

            }
        }

        private static void IncluirAluno()
        {
            var daoAluno = new AlunoDAL();

            var p2 = new Aluno();

            //Console.WriteLine("Digite o ID do aluno");
            //p2.AlunoID = Console.ReadLine();

            Console.WriteLine("Digite o nome do Aluno");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Matricula do Aluno");
            p2.Matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Email do Aluno");
            p2.Email = Console.ReadLine();

            p2.Endereco = new List<Endereco>
                {
                    CadastraEndereco()
                };

            daoAluno.Inserir(p2);
        }

        static Endereco CadastraEndereco()
        {
                var p1 = new Endereco();

                Console.WriteLine("Digite o Id do Endereco");
                p1.EnderecoID = Console.ReadLine();

                Console.WriteLine("Digite o Logradouro");
                p1.Logradouro = Console.ReadLine();

                return p1;
        }
    }


}


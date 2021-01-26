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
            IncluirAluno();
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();
        }

        private static void IncluirAluno()
        {
            using (var db = new AlunosContext())
            {

                var p2 = new Aluno();
                Console.WriteLine("Digite o nome do Aluno");
                p2.Nome = Console.ReadLine();

                Console.WriteLine("Digite a Matricula do Aluno");
                p2.Matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Email do Aluno");
                p2.Nome = Console.ReadLine();

                Console.WriteLine("Digite o nome do Aluno");
                p2.Nome = Console.ReadLine();

                p2.Endereco = new List<Endereco>
                {
                    new Endereco { }
                }

                db.Add(p2);
                db.SaveChanges();

            }

        private static Endereco CadastrarEndereco()
        {
            throw new NotImplementedException();
        }
    }
    }
}

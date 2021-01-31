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
            int w = 0;
            int escolha;
            var db = new AlunosContext();

            while (w == 0)
            {
                Console.WriteLine("******************************************\nEscolha uma opção: ");
                Console.WriteLine("1) Cadastrar Aluno\n2) Alterar Aluno\n3) Deletar Aluno \n4) Consultar por matricula\n5) Consultar por nome\n6) Sair do Programa");
                Console.WriteLine("******************************************");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        IncluirAluno(db);
                        break;
                    case 2:
                        AlterarAluno(db);
                        break;
                    case 3:
                        ExcluirAluno(db);
                        break;
                    case 4:
                        ConsultaPorMatricula(db);
                        break;
                    case 5:
                        AcharNomeAluno(db);
                        break;
                    case 6: w++; break;
                    default:
                        Console.WriteLine("Escolha não existente;");
                        break;
                }
            }
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();
        }

        private static void AcharNomeAluno(AlunosContext db)
        {
            string nome;
            Console.Write("Escreva a parte do nome da pesquisa: ");
            nome = Console.ReadLine();
            var aluno = (from x in db.Alunos where x.Nome.Contains(nome) select x).FirstOrDefault();
            if (aluno == null) Console.WriteLine("Aluno não existe");
            else Console.WriteLine($"Aluno: {aluno.Nome} Matricula: {aluno.Matricula} e Email: {aluno.Email}.");
        }

        private static void ConsultaPorMatricula(AlunosContext db)
        {
            int p1;
            var daoAluno = new AlunoDAL();
            Console.WriteLine("Digite a Matricula para realizar a busca:");
            p1 = Convert.ToInt32(Console.ReadLine());

            var p2 = (from x in db.Alunos where x.Matricula == p1 select x).FirstOrDefault();

            if (p2 == null)
                Console.WriteLine($"Matricula {p1} não encontrado.");
            else
            {
                p2 = daoAluno.ImprimirAluno(p2, p1);
                Console.WriteLine($"Nome:{p2.Nome}, \nMatricula:{p2.Matricula}, Email:{p2.Email}.");
                foreach (var item in p2.Endereco)
                {
                    Console.WriteLine($"Aluno:{p2.Nome}\nTipo de Endereco:{item.TipoEndereco}\nLogradouro:{item.Logradouro}\nCidade:{item.Cidade}, ");
                    Console.WriteLine($"Bairro:{item.Bairro}\nNumero:{item.Bairro}Complemento:{item.Complemento}");
                    
                }
            }
        }

        private static void ExcluirAluno(AlunosContext db)
        {
            int p1;
            var daoAluno = new AlunoDAL();
            Console.WriteLine("Digite a Matricula para realizar a exclusão:");
            p1 = Convert.ToInt32(Console.ReadLine());

            var p2 = (from x in db.Alunos where x.Matricula == p1 select x).FirstOrDefault();

            if (p2 == null)
                Console.WriteLine($"Matricula {p1} não encontrado.");
            else
            {
                daoAluno.Excluir(p2);
            }

        }

        private static void AlterarAluno(AlunosContext db)
        {
                int p1;
                int escolha, escolha2;
                int a = 0;
                var end = new List<Endereco>();
                var daoAluno = new AlunoDAL();

                Console.WriteLine("Digite a Matricula para realizar a alteração:");
                p1 = Convert.ToInt32(Console.ReadLine());


                var p2 = (from x in db.Alunos where x.Matricula == p1 select x).FirstOrDefault();

                if (p2 == null)
                    Console.WriteLine($"Produto de id {p1} não encontrado.");

                else
                {
                    adicionarAluno(db, p2);
                    Console.Write("Deseja Alterar Tabem O Endereco do Aluno? Se Sim digite 1, Se Nao digite 2: ");
                    escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha) 
                {
                    case 1:
                        {  
                            while (a == 0)
                            {
                                Console.Write("1 - Cadastrar novo Endereco\n2 - Alterar Enderenço\n3 - Sair");
                                escolha2 = Convert.ToInt32(Console.ReadLine());

                                switch (escolha2)
                                {
                                    case 1:
                                        adicionarEndereco(db, end);
                                        p2.Endereco = end;
                                        db.SaveChanges();
                                        break;
                                    case 2:alterarEndereco(db,p2.Endereco);break;
                                    case 3: a++; break;
                                }
                                
                            }
                            break;
                        }
                }
                daoAluno.Alterar(p2);
                
                }
        }

        private static void alterarEndereco(AlunosContext db, IList<Endereco> endereco)
        {

            string p1;
            Console.WriteLine("Qual tipo de Endereço ?");


            foreach (var item in endereco)
            {
                Console.WriteLine($"- {item.Logradouro}\n");
            }

            p1 = Console.ReadLine();
            var p2 = (from x in db.Enderecos where x.TipoEndereco == p1 select x).FirstOrDefault();

            Console.Write("Digite o tipo de endereco ( Residencial, Comercial, Cobrança, etc...): ");
            p2.TipoEndereco = Console.ReadLine();
            Console.Write("Logradouro: ");
            p2.Logradouro = Console.ReadLine();
            Console.Write("Numero: ");
            p2.Numero = Console.ReadLine();
            Console.Write("Complemento: ");
            p2.Complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            p2.Bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            p2.Cidade = Console.ReadLine();

            db.SaveChanges();

        }

        private static void IncluirAluno(AlunosContext db)
        {
            var end = new List<Endereco>();
            var al = new Aluno();
            adicionarAluno(db, al);
            adicionarEndereco(db, end);
            al.Endereco = end;
            salvarAluno(al);            
        }

        private static void salvarAluno(Aluno al)
        {
            var daoAluno = new AlunoDAL();
            daoAluno.Inserir(al);
        }

        private static void adicionarEndereco(AlunosContext db, List<Endereco> end)
        {
            int a = 0;
            int escolha;

            while (a == 0)
            {
                Console.WriteLine("1 - Cadastrar novo endereco\n2 - Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                switch(escolha)
                {
                    case 1:
                        {
                            end.Add(cadastrarEndereco());
                            break;
                        }
                    case 2: a++; break;
                }
            }          
        }

        private static Endereco cadastrarEndereco()
        {
            var p1 = new Endereco();
            Console.Write("Digite o tipo de endereco ( Residencial, Comercial, Cobrança, etc...): ");
            p1.TipoEndereco = Console.ReadLine();
            Console.Write("Logradouro: ");
            p1.Logradouro = Console.ReadLine();
            Console.Write("Numero: ");
            p1.Numero = Console.ReadLine();
            Console.Write("Complemento: ");
            p1.Complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            p1.Bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            p1.Cidade = Console.ReadLine();

            if (p1.EnderecoID == null)
                p1.EnderecoID = Guid.NewGuid().ToString();

            return p1;
        }

        private static void adicionarAluno(AlunosContext db, Aluno al)
        {
            Console.Write("Digite o nome do Aluno: ");
            al.Nome = Console.ReadLine();
            Console.Write("Matricula: ");
            al.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            al.Email = Console.ReadLine();
        }
    }
}


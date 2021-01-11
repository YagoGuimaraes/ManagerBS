using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoaFisica = new List<PessoaFisica>();
            var pessoaJuridica = new List<PessoaJuridica>();
            string escolha;
            int a = 0;

            while (a == 0)
            {
                Console.WriteLine("******************************************\nEscolha uma opção: ");
                Console.WriteLine("a) Cadastrar Pessoa Fisica\nb) Cadastrar Pessoa Juridica\nc) Imprimir etiqueta para correspondência: \nd) Imprimir listagem de produtos\ne) Sair do programa ");
                Console.WriteLine("******************************************");
                escolha = Console.ReadLine();

                switch(escolha)
                {
                    case "a":
                        CadastrarFisica(pessoaFisica);
                        break;

                    case "b":
                        CadastrarJuridica(pessoaJuridica);
                        break;

                    case "c":
                        ImprimirFisica(pessoaFisica);
                        ImprimirJuridica(pessoaJuridica);
                        break;
                    case "d":
                        ImprimirFisicaCobranca(pessoaFisica);
                        ImprimirJuridicaCobranca(pessoaJuridica);
                        break;
                    case "e":
                        ImprimirFisicaNotaPromissoria(pessoaFisica);
                        ImprimirJuridicaNotaPromissoria(pessoaJuridica);
                        break;

                    case "f":
                        a = 1;
                        break;
                 }
            }  
        }

        private static void ImprimirFisica(List<PessoaFisica> pessoaFisica)
        {
            foreach (var item in pessoaFisica)
            {
                Console.Write($"{item.Nome:C2}\n{item.Endereco:C2}\n\n");
            }
        }

        private static void ImprimirFisicaNotaPromissoria(List<PessoaFisica> pessoaFisica)
        {
            double valor;
            DateTime DataPagamento;
            foreach (var item in pessoaFisica)
            {
                Console.WriteLine("Digite o valor da Nota Promissória");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a data de pagamento");
                DataPagamento = Convert.ToDateTime(Console.ReadLine());
                Console.Write($"Eu {item.Nome:C2} prometo que vou pagar R${0} na data {1}\n\n", valor, DataPagamento);
            }
        }

        private static void ImprimirJuridicaNotaPromissoria(List<PessoaJuridica> pessoaJuridica)
        {
            double valor;
            DateTime DataPagamento;
            foreach (var item in pessoaJuridica)
            {
                Console.WriteLine("Digite o valor da Nota Promissória");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a data de pagamento");
                DataPagamento = Convert.ToDateTime(Console.ReadLine());
                Console.Write($"Eu {item.NomeContato:C2}, representante legal da {item.Nome:C2} prometo que vou pagar {0} na data {1}\n\n", valor, DataPagamento);
            }
        }


        private static void ImprimirJuridica(List<PessoaJuridica> pessoaJuridica)
        {
            foreach (var item in pessoaJuridica)
            {
                Console.Write($"{item.Nome:C2}\nAos cuidados de {item.NomeContato:C2}\n{item.Endereco:C2}\n\n");
            }
        }

        private static void ImprimirFisicaCobranca(List<PessoaFisica> pessoaFisica)
        {
            foreach (var item in pessoaFisica)
            {
                Console.Write($"Caro (a) {item.Nome:C2}\nVocê me deve!\n\n");
            }
        }

        private static void ImprimirJuridicaCobranca(List<PessoaJuridica> pessoaJuridica)
        {
            foreach (var item in pessoaJuridica)
            {
                Console.Write($"Caro (a) {item.NomeContato:C2}\n A {item.Nome:C2} me deve!\n\n");
            }
        }

        static void CadastrarFisica(List<PessoaFisica> pessoaFisica)
        {
            pessoaFisica.Add(RetornaPessoasFisica());


        }

        static PessoaFisica RetornaPessoasFisica()
        {
            var objeto = new PessoaFisica();
            Console.WriteLine("Digite o nome:");
            objeto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o email:");
            objeto.Email = Console.ReadLine();

            Console.WriteLine("Digite o Endereço:");
            objeto.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o CPF:");
            objeto.CPF = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento:");
            objeto.DataNascimento = Console.ReadLine();

            return objeto;


        }

        static void CadastrarJuridica(List<PessoaJuridica> pessoaJuridica)
        {
            pessoaJuridica.Add(RetornaPessoasJuridica());


        }

        static PessoaJuridica RetornaPessoasJuridica()
        {
            var objeto = new PessoaJuridica();
            Console.WriteLine("Digite o nome:");
            objeto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o email:");
            objeto.Email = Console.ReadLine();

            Console.WriteLine("Digite o Endereço:");
            objeto.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ:");
            objeto.CNPJ = Console.ReadLine();

            Console.WriteLine("Digite o nome do contato:");
            objeto.NomeContato = Console.ReadLine();

            return objeto;


        }



        private static PessoaFisica[] RetornaPessoas()
        {
            var pessoaFisica = new PessoaFisica
            {
                Nome = "Yago",
                Email = "yago.guimaraes@managerbs.com",
                Endereco = "Rua Guacui, 300/801 - Sao Mateus - Juiz de Fora",
                CPF = "119.357.476-57",
                DataNascimento = "13/08/1994"
            };          

            return new PessoaFisica[]
            {
                pessoaFisica               
            };
        }
    }
}

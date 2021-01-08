using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = RetornaPessoas();
            var pessoas2 = RetornaPessoas2();
            ImprimirFisica(pessoas);
            ImprimirJurifica(pessoas2);

        }

        private static void ImprimirFisica(PessoaFisica[] pessoas)
        {
            foreach(var item in pessoas)
            {
                 Console.Write($"Nome: {item.Nome:C2}\n");          
            }
        }

        private static void ImprimirJurifica(PessoaJuridica[] pessoas)
        {
            foreach (var item in pessoas)
            {
                Console.Write($"Nome: {item.Nome:C2}\n");
            }
        }

        private static PessoaFisica[] RetornaPessoas()
        {
            return new PessoaFisica[]
            {
                new PessoaFisica
                {
                    Nome = "Yago",
                    Email = "yago.guimaraes@managerbs.com",
                    Endereco = "Rua Guacui, 300/801 - Sao Mateus - Juiz de Fora",
                    CPF = "119.357.476-57",
                    DataNascimento = "13/08/1994"
                }
            };
        }

        private static PessoaJuridica[] RetornaPessoas2()
        {
            return new PessoaJuridica[]
            {
                new PessoaJuridica
                {
                    Nome = "ManagerBS",
                    Email = "managerbs@managerbs.com",
                    Endereco = "Rua ataliba de barros 182/113 - Sao Mateus - Juiz de Fora",
                    CNPJ = "30.152.302/0001-32",
                    NomeContato = "Flávio"
                }

            };           

        }
        
}
}

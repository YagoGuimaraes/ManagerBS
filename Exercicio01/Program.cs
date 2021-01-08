using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = RetornaPessoas();
            Imprimir(pessoas);
        }

        private static void Imprimir(IPessoa[] pessoas)
        {
            foreach(var item in pessoas)
            {
                Console.Write($"Nome: {item.Nome:C2}");
            }
        }

        private static IPessoa[] RetornaPessoas()
        {
            return new IPessoa[]
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
    }
}

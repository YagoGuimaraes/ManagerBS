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


            foreach (var item in pessoas.)
            {
                Console.Write($"Nome: {item.Nome:C2}\n");          
            }
        }

        private static IPessoa[] RetornaPessoas()
        {
            var pessoaFisica = new PessoaFisica
            {
                Nome = "Yago",
                Email = "yago.guimaraes@managerbs.com",
                Endereco = "Rua Guacui, 300/801 - Sao Mateus - Juiz de Fora",
                CPF = "119.357.476-57",
                DataNascimento = "13/08/1994"
            };

            var cadastroJuridica = new PessoaJuridica
            {
                Nome = "ManagerBS",
                Email = "managerbs@managerbs.com",
                Endereco = "Rua ataliba de barros 182/113 - Sao Mateus - Juiz de Fora",
                CNPJ = "30.152.302/0001-32",
                NomeContato = "Flávio"
            };

            return new IPessoa[]
            {
                pessoaFisica,
                cadastroJuridica
            };
        }
    }
}

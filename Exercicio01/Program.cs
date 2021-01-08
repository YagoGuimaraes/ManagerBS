using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoasFissica = RetornaPessoas();
            Imprimir(pessoasFissica);
            
        }

        private static void Imprimir(PessoaFisica[] pessoasFissica)
        {


            foreach (var item in pessoasFissica)
            {
                Console.Write($"Nome: {item.Nome:C2}\n");          
            }
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

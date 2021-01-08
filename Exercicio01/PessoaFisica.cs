using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class PessoaFisica : IPessoa
    {
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public string CPF { get; set; }
        public string DataNascimento { get; set; }

        private string nome;
        private string email;
        private string endereco;

    }
}

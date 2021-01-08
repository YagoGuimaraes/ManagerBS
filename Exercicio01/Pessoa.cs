using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Pessoa : IPessoa
    {




        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        private string nome;
        private string email;
        private string endereco;
 
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class PessoaFisica : Pessoa
    {
        public PessoaFisica()
        {
            pessoaInfo = new Pessoa();
        }

        public string CPF { get; set; }
        public string DataNascimento { get; set; }

        private Pessoa pessoaInfo;
    }
}

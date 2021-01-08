using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class PessoaJuridica : Pessoa
    {
        public PessoaJuridica()
        {
            pessoaInfo = new Pessoa();
        }



        public string CNPJ { get; set; }
        public string NomeContato { get; set; }

        private Pessoa pessoaInfo;
    }
}

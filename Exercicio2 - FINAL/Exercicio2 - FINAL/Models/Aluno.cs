﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2___FINAL.Models
{
    class Aluno
    {
        public string AlunoID { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public IList<Endereco> Endereco { get; set; } = new List<Endereco>();
    }
}

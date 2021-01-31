using Exercicio2___FINAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio2___FINAL.DAL
{
    class AlunoDAL
    {
        public void Inserir(Aluno obj)
        {
            using (var contexto = new AlunosContext())
            {
                if (obj.AlunoID == null)
                    obj.AlunoID = Guid.NewGuid().ToString();

                contexto.Add(obj);
                contexto.SaveChanges();
            }
        }

        public void Alterar(Aluno obj)
        {
            using (var contexto = new AlunosContext())
            {
                contexto.Update(obj);
                contexto.SaveChanges();
            }
        }


        public Aluno ImprimirAluno(Aluno aluno, int matricula)
        {
            using (var alunos = new AlunosContext())
            {
                aluno = alunos.Alunos.Where(x => x.Matricula == matricula).FirstOrDefault();
            }

            return aluno;
        }

        public void Excluir(Aluno obj)
        {
            using (var contexto = new AlunosContext())
            {
                contexto.Remove(obj);
                contexto.SaveChanges();
            }
        }



    }
}

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

        public void Excluir(Aluno obj)
        {
            using (var contexto = new AlunosContext())
            {
                //Recupera todos os itens gravados na base
                var itensAnteriores = contexto.Alunos.Where(x => x.Matricula == obj.Matricula).ToList();

                //Altera o State de cada item para Deleted
                foreach (var item in itensAnteriores)
                    contexto.Entry(item).State = EntityState.Deleted;

                //Altera o state do pedido para Deleted
                contexto.Entry(obj).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}

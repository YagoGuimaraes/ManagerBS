using Exercicio2___FINAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2___FINAL.DAL
{
    class AlunosContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasMany(e => e.Endereco).WithOne().OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
         options.UseSqlServer(@"Integrated Security=SSPI;Trusted_Connection=false;Persist Security Info=False;Initial Catalog=TesteCS;user id=sa;password=kk10199;Data Source=192.168.88.76\manager");
    }
}

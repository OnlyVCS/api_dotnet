using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models; //Pegando os modelos da pasta Models e jogando ai em baixo no DbSet
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Classe q vai me permitir navegar por minhas tabelas.
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions) //Basicamente passa o conteudo de dbContextOptions para o DbContext em cima pra ser usado em outros lugares
        {
            
        }

        public DbSet<Stock> Stocks { get; set; } //DbSet vai pegar algo da DB (tabela) para que eu possa fazer algo com ele
        public DbSet<Comment> Comments { get; set; } // Essas são as tabelas
    }
}
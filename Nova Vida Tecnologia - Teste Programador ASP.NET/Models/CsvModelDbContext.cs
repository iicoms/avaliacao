using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models
{
    public class CsvModelDbContext : DbContext
    {
        public CsvModelDbContext(DbContextOptions<CsvModelDbContext> options)
        : base(options)
        { }
        public DbSet<CsvModel> CsVM { get; set; }
    }
   
}

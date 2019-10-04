using Microsoft.EntityFrameworkCore;
using TrabalhoG1.Models;

namespace TrabalhoG1.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
    }
}
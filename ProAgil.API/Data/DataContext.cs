using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base (option){}

        public  virtual DbSet<Evento> Eventos { get; set; }
        
    }
}
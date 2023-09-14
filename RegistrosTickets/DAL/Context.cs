using Microsoft.EntityFrameworkCore;
using RegistrosTickets.Models;

namespace RegistrosTickets.DAL
{
    public class Context : DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}

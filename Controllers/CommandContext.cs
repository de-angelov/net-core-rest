using Microsoft.EntityFrameworkCore;

namespace CmdApi.Models
{
  public class CommandContext : DbContext
  {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=123");
        public DbSet<Command> CommandItems {get; set;
      
  }
}
}

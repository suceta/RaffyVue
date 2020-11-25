
namespace RaffyVue.DataModels
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    public class VueDBContext : DbContext
    {
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        public VueDBContext(DbContextOptions<VueDBContext> option) : base(option)
        {
        }
    }
}

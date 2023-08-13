using System.Data.Entity;

namespace WebApplication2.Models.Repository
{
    public class EFDBContext : DbContext
    {
        public DbSet<GoodsModel> Goods { get; set; }
    }
}

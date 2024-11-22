using Microsoft.EntityFrameworkCore;
using ProniaMVC.Helpers;
using ProniaMVC.Models;
namespace ProniaMVC.Contexts
{
    public class ProniaDbContext : DbContext
    {
        public ProniaDbContext()
        {
        }

        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options) { }
      public DbSet<SliderItem> SliderItems {  get; set; }
   
    }
}

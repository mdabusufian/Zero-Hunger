using System.Data.Entity;

namespace Zero_Hunger_Mid.Models
{
    public class DataConn : DbContext
    {
        public DbSet<Rest> Rests { get; set; }

        public DbSet<FoodCollect> FoodCollects { get; set; }

    }
}
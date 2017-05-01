using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using YBoardAPI.Model;


namespace YBoardAPI.Data
{
    public class StockEntities : DbContext
    {
        public StockEntities() : base("StockEntities") { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<TradeDay> TradeDays { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configuration.CompanyConfiguration());
            modelBuilder.Configurations.Add(new Configuration.IndustryConfiguration());
            modelBuilder.Configurations.Add(new Configuration.TradeDayConfiguration());
        }
    }
}

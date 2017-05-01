using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using YBoardAPI.Model;

namespace YBoardAPI.Data.Configuration
{
    public class TradeDayConfiguration : EntityTypeConfiguration<TradeDay>
    {
        public TradeDayConfiguration()
        {
            ToTable("TradeDays");
            Property(t => t.CompanyId).IsRequired().HasMaxLength(10);
        }
    }
}
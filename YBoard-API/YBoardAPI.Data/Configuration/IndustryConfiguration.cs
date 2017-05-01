using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using YBoardAPI.Model;

namespace YBoardAPI.Data.Configuration
{
    public class IndustryConfiguration : EntityTypeConfiguration<Industry>
    {
        public IndustryConfiguration()
        {
            ToTable("Industries");
            Property(i => i.Name).IsRequired().HasMaxLength(50);
        }
    }
}

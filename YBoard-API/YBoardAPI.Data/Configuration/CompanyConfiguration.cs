using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using YBoardAPI.Model;


namespace YBoardAPI.Data.Configuration
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            ToTable("Companies");
            Property(c => c.Code).IsRequired().HasMaxLength(5);
        }
    }
}

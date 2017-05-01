using YBoardAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBoardAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        StockEntities dbContext;

        public StockEntities Init()
        {
            return dbContext ?? (dbContext = new StockEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

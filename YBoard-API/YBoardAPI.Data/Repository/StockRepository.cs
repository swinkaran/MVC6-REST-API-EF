using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YBoardAPI.Data.Infrastructure;
using YBoardAPI.Model;

namespace YBoardAPI.Data.Repository
{
    public class StockRepository : RepositoryBase<TradeDay>, IStockRepository
    {

        public StockRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        
    } 

    public interface IStockRepository : IRepository<TradeDay>
    {
        //Category GetCategoryByName(string categoryName);
    }
}

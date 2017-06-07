using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using YBoardAPI.Model;
using YBoardAPI.Data;
using YBoardAPI.Data.Repository;
using YBoardAPI.Data.Infrastructure;

namespace YBoardAPI.Service
{
    public class StockService : IStockService
    {
        public IStockRepository ITradeDayRepository;
        private readonly IUnitOfWork unitOfWork;

        public StockService(IStockRepository tradeDay, IUnitOfWork unitOfWork)
        {
            ITradeDayRepository = tradeDay;
            this.unitOfWork = unitOfWork;
        }

        public IList<TradeDay> GetAllStocks()
        {
            return ITradeDayRepository.GetAll().ToList();
        }

        public IEnumerable<TradeDay> GetTradeDays()
        {
            return ITradeDayRepository.GetAll();
        }

        public IEnumerable<TradeDay> GetTradeDays(long id)
        {
            return ITradeDayRepository.GetAll().Where(t => t.CompanyId == id).ToList();
        }

        public void SaveArticle()
        {
            unitOfWork.Commit();
        }
    }

    public interface IStockService
    {
        IEnumerable<Model.TradeDay> GetTradeDays();
        IEnumerable<Model.TradeDay> GetTradeDays(long id);
        void SaveArticle();
    }
}
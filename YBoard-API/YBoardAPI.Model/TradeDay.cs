using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBoardAPI.Model
{
    public class TradeDay
    {

        public long Id { get; set; }
        public string CompanyId { get; set; }
        public DateTime Date { get; set; }
        public Decimal OpenPrice { get; set; }
        public Decimal HighPrice { get; set; }
        public Decimal LowPrice { get; set; }
        public Decimal ClosePrice { get; set; }
        public long Volume { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBoardAPI.Model
{
    public class Company
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Industry Industry { get; set; }
    }
}

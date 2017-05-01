using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YBoardAPI.Data;
using YBoardAPI.Data.Repository;

namespace YBoardAPI.Interface.Controllers
{
    public class HomeController : Controller
    {
        private StockRepository _stockRepository;

        public HomeController()
        {
         
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Patriotisk.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Videoes()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
    }
}
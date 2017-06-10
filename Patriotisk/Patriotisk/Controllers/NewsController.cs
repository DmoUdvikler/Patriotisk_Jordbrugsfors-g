using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patriotisk.Models;

namespace Patriotisk.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Subscriber());
        }

        [HttpPost]
        public ActionResult Create(Subscriber Subscriber)
        {
            if (ModelState.IsValid)
            {
                //does something 
            }
            else
            {
              
            }
            return RedirectToAction("Index");
        }

    }
}
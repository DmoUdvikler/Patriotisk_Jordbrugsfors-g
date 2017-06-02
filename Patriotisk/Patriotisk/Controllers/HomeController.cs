using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB;
using MongoDB.Driver;
using Patriotisk.Models;
using MongoDB.Bson;
using Patriotisk.Persistence;

namespace Patriotisk.Controllers
{
    public class HomeController : Controller
    {
        MongoDBPersistence mongo; 
        public HomeController()
        {
            mongo = new MongoDBPersistence(); 
        }
        [Route("api/home/index")]
        [HttpGet]
        public IActionResult Index()
        {

            return View(mongo.GetExperiments());
        }
       
        [Route("api/Home/Experiment")]
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Experiment());
        }
        [Route("api/Home/Experiment")]
        [HttpPost]
        public ActionResult Create(Experiment experiment)
        {
            mongo.Save(experiment); 
            return RedirectToAction("Index");
        }
        [Route("api/Home/Edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            List<Experiment> experiments = mongo.FindExperiment(id); 
            TempData["ObjectID"] = experiments[0].Id.ToString();
            return View(experiments[0]);
        }

        [Route("api/Home/Edit")]
        [HttpPost]
        public ActionResult Edit(Experiment experiment)
        {
            if (ModelState.IsValid)
            {
                string id = TempData["ObjectID"].ToString();
                mongo.Edit(experiment, id);              
            }
            return RedirectToAction("Index");
        }
        [Route("api/Home/Delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            mongo.Delete(id); 
            return RedirectToAction("Index");
        }

    }
}

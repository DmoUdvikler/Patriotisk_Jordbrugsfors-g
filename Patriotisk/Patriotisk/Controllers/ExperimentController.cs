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

using Microsoft.AspNetCore.Http;

namespace Patriotisk.Controllers
{
    public class ExperimentController : Controller
    {
        MongoDBPersistence mongo;
        public ExperimentController()
        {
            mongo = new MongoDBPersistence();
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            //return View(mongo.GetExperimentsByCrop("Raps")); Test
            return View(mongo.GetExperiments());
        }

        //[HttpGet] Doesnt work
        //public ActionResult GetByYear(string year)
        //{

        //    return View("Index", mongo.GetExperimentsByYear(year));
        //}
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Experiment());
        }
        [HttpPost]
        public ActionResult Create(Experiment experiment)
        {
            mongo.Save(experiment);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            List<Experiment> experiments = mongo.FindExperiment(id);
            TempData["ObjectID"] = experiments[0].Id.ToString();
            return View(experiments[0]);
        }

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
        [HttpGet]
        public ActionResult Delete(string id)
        {
            mongo.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}

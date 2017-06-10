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
            return View(mongo.GetExperiments());
        }
        [HttpGet]

        [Route("api/Experiment/Graph")]
        public IActionResult GraphSuff(int id)
        {
            string[,] toReturn;
            if (id == 1)
            {
                toReturn = new string[4, 2];
                toReturn[0, 0] = "3347";
                toReturn[0, 1] = "Ubehandlet 40 pl";
                toReturn[1, 0] = "3322";
                toReturn[1, 1] = "Ubehandlet 40 pl";
                toReturn[2, 0] = "3442";
                toReturn[2, 1] = "1,5 l Folicur Xpert 40 pl";
                toReturn[3, 0] = "3488";
                toReturn[3, 1] = "1,5 l Folicur Xpert 20 pl";    
            }
            else
            {
                toReturn = new string[2, 2];
                toReturn[0, 0] = "2000";
                toReturn[0, 1] = "Ubehandlet 40 pl";
                toReturn[1, 0] = "4000";
                toReturn[1, 1] = "Caryx 40 pl";
            }            
            return Ok(toReturn);
        }
        [HttpGet]
        public IActionResult ShowByYear(string year)
        {
            return View("ShowBy", mongo.GetExperimentsByYear(year));
        }
        [HttpGet]
        public IActionResult ShowByYearAdmin(string year)
        {
            return View("Index", mongo.GetExperimentsByYear(year));
        }
        [HttpGet]
        public IActionResult ShowByCrop(string crop)
        {
            return View("ShowBy", mongo.GetExperimentsByCrop(crop));
        }
        [HttpGet]
        public IActionResult ShowByCropAdmin(string crop)
        {
            return View("Index", mongo.GetExperimentsByCrop(crop));
        }

        [HttpGet]
        public IActionResult AddData()
        {
            return View();
        }
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
    }
}

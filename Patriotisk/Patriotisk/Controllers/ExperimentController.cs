//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using MongoDB;
//using MongoDB.Driver;
//using Patriotisk.Models;
//using MongoDB.Bson;
//using Patriotisk.Persistence;
//using Microsoft.AspNetCore.Http;

//namespace Patriotisk.Controllers
//{
//    public class ExperimentController : Controller
//    {
//        MongoDBPersistence mongo;
//        public ExperimentController()
//        {
//            mongo = new MongoDBPersistence();
//        }


//        //POST: Home/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Home/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Home/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        [Route("api/home/index")]
//        [HttpGet]
//        public IActionResult Index()
//        {
//            //return View(mongo.GetExperimentsByCrop("Raps")); Test
//            return View(mongo.GetExperiments());
//        }

//        //[HttpGet] Doesnt work
//        //public ActionResult GetByYear(string year)
//        //{

//        //    return View("Index", mongo.GetExperimentsByYear(year));
//        //}
//        [Route("api/Home/Experiment")]
//        [HttpGet]
//        public ActionResult Create()
//        {
//            return View(new Experiment());
//        }
//        [Route("api/Home/Experiment")]
//        [HttpPost]
//        public ActionResult Create(Experiment experiment)
//        {
//            mongo.Save(experiment);
//            return RedirectToAction("Index");
//        }
//        [Route("api/Home/Edit")]
//        [HttpGet]
//        public ActionResult Edit(string id)
//        {
//            List<Experiment> experiments = mongo.FindExperiment(id);
//            TempData["ObjectID"] = experiments[0].Id.ToString();
//            return View(experiments[0]);
//        }

//        [Route("api/Home/Edit")]
//        [HttpPost]
//        public ActionResult Edit(Experiment experiment)
//        {
//            if (ModelState.IsValid)
//            {
//                string id = TempData["ObjectID"].ToString();
//                mongo.Edit(experiment, id);
//            }
//            return RedirectToAction("Index");
//        }
//        [Route("api/Home/Delete")]
//        [HttpGet]
//        public ActionResult Delete(string id)
//        {
//            mongo.Delete(id);
//            return RedirectToAction("Index");
//        }

//        // POST: Home/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//    }
//}

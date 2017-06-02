using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver.V1;
using Patriotisk.Models;
using MongoDB.Bson;
using Neo4jClient;

namespace Patriotisk.Controllers
{
    public class HomeN4JController : Controller
    {

        // GET: HomeN4J
        [Route("api/HomeNeo4J/NIndex")]
        [HttpGet]
        public ActionResult NIndex()
        {




            return View();
        }



        // GET: HomeN4J/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeN4J/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeN4J/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeN4J/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeN4J/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeN4J/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeN4J/Delete/5
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
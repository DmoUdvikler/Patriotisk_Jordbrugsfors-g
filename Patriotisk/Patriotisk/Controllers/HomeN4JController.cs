using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver.V1;
using Patriotisk.Models;
using MongoDB.Bson;

namespace Patriotisk.Controllers
{
    public class HomeN4JController : Controller
    {

        // GET: HomeN4J
        [Route("api/HomeNeo4J/NIndex")]
        [HttpGet]
        public ActionResult NIndex()
        {
            using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "eal0309892")))
            using (var session = driver.Session())
            {
                session.Run("CREATE (a:Experiment { id: {id}, name: {name}, treatment:{treatment}, sort: {sort}, fieldnumber:{fieldnumber}})",
                            new Dictionary<string, object> { { "id", "1" }, { "name", "Rapsforsøg" }, { "treatment", "testtreatment" }, { "sort", "raps" }, { "fieldnumber", "D14" } });

                var result = session.Run("MATCH (e:Experiment) WHERE e.sort = {sort} " +
                "RETURN e.id as id, e.name AS name, e.treatment AS treatment,e.sort as sort, e.fieldnumber as fieldnumber",
                                         new Dictionary<string, object> { { "sort", "raps" } });
                //session.Run("CREATE (a:Person {name: {name}, title: {title}})",
                //new Dictionary<string, object> { { "name", "Arthur" }, { "title", "King" } });

                //var result = session.Run("MATCH (a:Person) WHERE a.name = {name} " +
                //                         "RETURN a.name AS name, a.title AS title",
                //                         new Dictionary<string, object> { { "name", "Arthur" } });


                IList<NeoExperiment> experiments = new List<NeoExperiment>();
                  foreach (var record in result)
                {
                    NeoExperiment newEx = new NeoExperiment();
                    newEx.Id = record["id"].As<string>();
                    newEx.Name = record["name"].As<string>();
                    newEx.Treatment = record["treatment"].As<string>();
                    newEx.Sort = record["sort"].As<string>();
                    newEx.FieldName = record["fieldnumber"].As<string>();
                    experiments.Add(newEx);
                }
                  
                return View(experiments);
            }
           
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
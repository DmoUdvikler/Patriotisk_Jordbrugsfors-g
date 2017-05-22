﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB;
using MongoDB.Driver;

namespace Patriotisk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var client = new MongoClient("mongodb://juli301x:<eal0309892%40@>@cluster0-shard-00-00-nvnir.mongodb.net:27017,cluster0-shard-00-01-nvnir.mongodb.net:27017,cluster0-shard-00-02-nvnir.mongodb.net:27017/<DATABASE>?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin");
            var database = client.GetDatabase("test");
            
            return View();
        }
        [Route("api/Home/CreateExperiment")]
        [Produces("application/json")]
        [HttpPost]
        public IActionResult CreateExperiment(bool[] toRoll)
        {
            int toReturn = 3; 

            return Ok(toReturn);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

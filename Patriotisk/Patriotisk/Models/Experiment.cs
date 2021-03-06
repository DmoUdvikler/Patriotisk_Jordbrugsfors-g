﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patriotisk.Models
{
    [BsonIgnoreExtraElements]
    public class Experiment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Treatment { get; set; }
        public string Crop { get; set; }
        public string FieldName { get; set; }
        public string Year { get; set; }
        public Experiment()
        {

        }
    }
}

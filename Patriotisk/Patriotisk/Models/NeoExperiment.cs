using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patriotisk.Models
{
    public class NeoExperiment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Treatment { get; set; }
        public string Crop { get; set; }
        public string FieldName { get; set; }
        public NeoExperiment()
        {

        }
    }
}

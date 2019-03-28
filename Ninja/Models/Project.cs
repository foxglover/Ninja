using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninja.Models
{
    public class Project
    {
        public long ProjectId { get; set; }
        public long ClientId { get; set; }
        public string ProjectName { get; set; }
        public DateTime PredStart { get; set; }
        public DateTime PredFinish { get; set; }
        public DateTime ActStart { get; set; }
        public DateTime ActFinish { get; set; }
        public float PredCost { get; set; }
        public float ActCost { get; set; }

    }
}
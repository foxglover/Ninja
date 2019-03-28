using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninja.Models
{
    public class Activity
    {
        public long ActivityId { get; set; }
        public long ProjectId { get; set; }
        public string ActivityName { get; set; }
        public DateTime PredStart { get; set; }
        public DateTime PredFinish { get; set; }
        public DateTime ActStart { get; set; }
        public DateTime ActFinish { get; set; }
        public float PredCost { get; set; }
        public float ActCost { get; set; }
        public string ActDependencies { get; set; }
    }
}
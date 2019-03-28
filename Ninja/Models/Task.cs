using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninja.Models
{
    public class Task
    {
        public long TaskId { get; set; }
        public long ActivityId { get; set; }
        public string TaskName { get; set; }
        public DateTime PredStart { get; set; }
        public DateTime PredFinish { get; set; }
        public DateTime ActStart { get; set; }
        public DateTime ActFinish { get; set; }
        public float PredCost { get; set; }
        public float ActCost { get; set; }
        public string TaskDependencies { get; set; }
    }

}

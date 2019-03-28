using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninja.Models
{
    public class Staff
    {
        public long StaffId { get; set; }
        public string JobTitle { get; set; }

        public bool IsPerm { get; set; }

    }
}
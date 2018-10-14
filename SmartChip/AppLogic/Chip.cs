using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogic
{
    public class Chip
    {
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string _id { get; set; }
        public string name { get; set; }
        public List<string> options { get; set; }
        public string admin { get; set; }
        public string action { get; set; }
        public bool isGlobal { get; set; }

        public Chip()
        {

        }
    }
}

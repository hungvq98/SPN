using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex3.Models.Modelview
{
    public class Courseview
    {
        public int ID { get; set; }
        public string namecourse { get; set; }
        public string img { get; set; }
        public string contentcourse { get; set; }
        public double price { get; set; }
        public string grade { get; set; }
        public int time { get; set; }
        public string material { get; set; }
        public string teacher { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
    }
}
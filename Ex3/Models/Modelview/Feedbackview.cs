using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex3.Models.Modelview
{
    public class Feedbackview
    {
        public int ID { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string receiveddate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectAPP.MODEL
{
    public class Patient
    {
        public int Id { get; set; }
        public string VoterId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Age { get; set; }
    }
}
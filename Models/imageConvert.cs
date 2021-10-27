using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JrDevRequirement.Models
{
    public class imageConvert
    {
        public string name { get; set; }
        public string base64 { get; set; }
        public DateTime dateConverted { get; set; } = DateTime.Now;
    }
}
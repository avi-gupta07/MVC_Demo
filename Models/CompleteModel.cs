using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Models
{
    public class CompleteModel
    {
        public List<SelectListItem> Country { get; set; }

        public List<SelectListItem> Province { get; set; }

        public List<SelectListItem> City { get; set; }
      
    }
}
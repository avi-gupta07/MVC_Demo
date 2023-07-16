using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class CountryDTO
    {
        public int CountryID { get; set; }

        [DisplayName("Country Name")]
        public string CountryName { get; set; }
    }
}
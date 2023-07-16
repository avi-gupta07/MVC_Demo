using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class ProvinceDTO
    {
        public int ProvinceID { get; set; }

        [DisplayName("Province Name")]
        public string ProvinceName { get; set; }
        public int CountryID { get; set; }
    }
}
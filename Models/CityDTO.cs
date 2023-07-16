using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class CityDTO
    {
        public int CityID { get; set; }

        [DisplayName("City Name")]
        public string CityName { get; set; }
        public int ProvinceID { get; set; }
    }
}
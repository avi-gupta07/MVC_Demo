using MVC_Demo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{

    public class UserSelectionController : Controller
    {

        [HttpGet]
        public JsonResult FetchCountries()
        {
            UserDBContext userDBContext = new UserDBContext();
            List<Country> list_country = userDBContext.Countries.ToList();
            List<CountryDTO> list_country_DTO = new List<CountryDTO>();

            foreach (Country c in list_country)
            {
                CountryDTO countryDTO = new CountryDTO()
                {
                    CountryID = c.CountryID,
                    CountryName = c.CountryName
                };
                list_country_DTO.Add(countryDTO);
            }
           // String json = JsonConvert.SerializeObject();
            return Json(list_country_DTO, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult FetchProvinces(int Cid) {
            UserDBContext userDBContext = new UserDBContext();
            List<Province> list_provinces = userDBContext.Provinces
                                       .Where(province =>province.CountryID == Cid)
                                       .ToList();

            List<ProvinceDTO> list_provinces_DTO = new List<ProvinceDTO>();

            foreach (Province pv in list_provinces)
            {
                ProvinceDTO provinceDTO = new ProvinceDTO()
                {
                    ProvinceID = pv.ProvinceID,
                    ProvinceName = pv.ProvinceName
                };
                list_provinces_DTO.Add(provinceDTO);

            }
            return Json(list_provinces_DTO, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult FetchCities(int Pid)
        {
            UserDBContext userDBContext = new UserDBContext();
            List<City> list_cities = userDBContext.Cities
                                       .Where(city => city.ProvinceID == Pid)
                                       .ToList();
            List<CityDTO> list_cities_DTO = new List<CityDTO>();
            foreach (City city in list_cities)
            {
                CityDTO cityDTO = new CityDTO()
                {
                    CityID = city.CityID,
                    CityName = city.CityName,
                };
                list_cities_DTO.Add(cityDTO);       
            }  

            return Json(list_cities_DTO, JsonRequestBehavior.AllowGet);
        }
         
        // GET: UserSelection
        public ActionResult Index()
        {
            CompleteModel model = new CompleteModel();
            return View(model);
        }
    }
}
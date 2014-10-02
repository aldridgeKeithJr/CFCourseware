using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CarListerController : Controller
    {
        // GET: CarLister
        [Authorize]
        public ActionResult CarLister()
        {
            var cars = new[] 
                {
                    new CarViewModel { Year = "1949", Make = "Jaguar", Model = "XK120", PicUrl = "~/img/1949_Jaguar_xk120.jpg", Value = 298300},
                    new CarViewModel { Year = "1973", Make = "Porsche", Model = "911 Carerra RS", PicUrl = "~/img/1973_Porsche_911_RS.jpg", Value = 95500},
                    new CarViewModel { Year = "1993", Make = "Mazda", Model = "Miata", PicUrl = "~/img/1993_Mazda_Miata_LE.jpg", Value = 6500},
                    new CarViewModel { Year = "2014", Make = "Ford", Model = "Fusion", PicUrl = "~/img/2014_Ford_Fusion.jpg", Value = 30750},
                    new CarViewModel { Year = "2014", Make = "Kia", Model = "Optima", PicUrl = "~/img/2014_Kia_Optima.jpg", Value = 32900},
                    new CarViewModel { Year = "2015", Make = "Hennessey", Model = "Venom F5", PicUrl = "~/img/Hennessey_Venom_F5.jpg", Value = 1437000}
                };

            //return View(cars);

            // this should only be run once to populate the database table, then we about this file and scaffold the Cars model
            var Db = new CarListerDBContext();
            foreach (var item in cars)
            {
                Db.Cars.Add(item);
            }
            Db.SaveChanges();

            return View(Db.Cars.ToList());
        }


    }
}
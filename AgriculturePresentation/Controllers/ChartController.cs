using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<productClass> productClasses = new List<productClass>();

            productClasses.Add(new productClass
            {
               productname="Buğday",
                productvalue = 850
            });

            productClasses.Add(new productClass
            {
                productname = "Mercimek",
                productvalue = 480
            });

            productClasses.Add(new productClass
            {
                productname = "Arpa",
                productvalue = 250
            });

            productClasses.Add(new productClass
            {
                productname = "Pirinç",
                productvalue = 120
            });

            productClasses.Add(new productClass
            {
                productname = "Domates",
                productvalue = 960
            });

            return Json(new { jsonlist = productClasses });
        }
    }
}

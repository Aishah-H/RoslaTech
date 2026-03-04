using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RoslaTechs.Models;

namespace RoslaTechs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

       
        public IActionResult Consultation(Consultation model)
        {
            if (model.Name != null || model.Email != null)
            {
                model.Message = "Thank you for your consultation request, we will get back to you soon!";
            }
            else
            {
                model.Message = "Please fill in all required fields.";
            }
            return View(model);
        }

        public IActionResult CarbonFootprint(CarbonFootprint model)
        {
            if (ModelState.IsValid)
            {
                model.Message ="Sorry this page is still under construction";
            }
            else
            {
                model.Message = "Please fill in all required fields.";
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult CalcCarbonFoot(CarbonFootprint model)
        {
            model.Message = "Sorry this page is still under construction";
            return View("CarbonFootprint", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

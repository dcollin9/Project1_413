using Group1_7_Project1_IS413.Models;
using Group1_7_Project1_IS413.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Controllers
{
    public class HomeController : Controller
    {
        
        private ITourRepository _repository;
        private Tour tourData;
        private readonly ILogger<HomeController> _logger;

        public string tourIDa { get; set; }
        public HomeController(ILogger<HomeController> logger, ITourRepository repository)
        {
            _logger = logger;
            _repository = repository; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signups()
        {
            if (ModelState.IsValid)
            {
                return View(new TourListViewModel
                { Tours = _repository.Tours 
                    .Where (t => t.Avail== true)
                });
            }
            return View();
        }

        [HttpPost]
        public IActionResult Signups(Tour tour)
        {
            //TempStorage.AddTime(timeInfo);
            if (ModelState.IsValid)
            {
                return View("Form", tour);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View();
            };
            return View();
        }

        [HttpPost]
        public IActionResult Form(Tour tour)
        {
            TempStorage.AddTime(tour);
                    return View("Form", tour);
        }

        //public IActionResult ViewAppointments ()
        //{
         //   if (ModelState.IsValid)
          //  {
            //    //Bring in the schedule of availability
              //  return View(
                //{
                  //  Tours = _repository.Tours
                    //.Where(s => s.GroupName == null)
                    
                //});
            //}; 
            //return View();
        //}

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

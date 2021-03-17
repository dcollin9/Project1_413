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
        private LearnASPNETMVCWithRealAppsEntities db = new LearnASPNETMVCWithRealAppsEntities();
        private ITourRepository _repository;
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
                //Bring in the schedule of availability
                return View(new TourListViewModel
                {
                    Tours = _repository.Tours
                    .Where(s => s.GroupName == null)
                    
                });
            };
            return View();
        }

        [HttpPost]
        public IActionResult Signups(Tour tour)
        {
            
            return View("Form", tour);
        }

        [HttpGet]
        public IActionResult Form(Tour tour)
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View(tour);
            };
            return View();
        }

        [HttpPost]
        public IActionResult Form(Tour tour)
        {

            using (var context = new demoCRUDEntities())
            {
                // Use of lambda expression to access 
                // particular record from a database 
                var data = context.Student.FirstOrDefault(x => x.StudentNo == Studentid);
                // Checking if any such record exist  
                if (data != null)
                {
                    data.Name = model.Name;
                    data.Section = model.Section;
                    data.EmailId = model.EmailId;
                    data.Branch = model.Branch;
                    context.SaveChanges();
                    // It will redirect to  
                    // the Read method 
                    return RedirectToAction("Read");
                }
                else
                    return View();
            }

        public IActionResult ViewAppointments ()
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View(new TourListViewModel
                {
                    Tours = _repository.Tours
                    .Where(s => s.GroupName == null)
                    
                });
            }; 
            return View();
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

using Group1_7_Project1_IS413.Models;
using Group1_7_Project1_IS413.Models.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly ILogger<HomeController> _logger;
        public IApplicationBuilder _app;
        private TourDbContext context { get; set; }

        //constructor for the home controller
        public HomeController(ILogger<HomeController> logger, ITourRepository repository, TourDbContext con)
        {
            _logger = logger;
            _repository = repository;
            context = con;
            
        }

        //returns the home page
        public IActionResult Index()
        {
            return View();
        }


        //grabs the signup page, which allows the user to select an appointment date and time to sign up for
        [HttpGet]
        public IActionResult Signups()
        {
            if (ModelState.IsValid)
            {
                //passes in appointments from the database if the appointments are available
                return View(new TourListViewModel
                { Tours = _repository.Tours 
                    .Where (t => t.Avail== true)
                    .OrderBy(t => t.DayTime)
                });
            }
            return View();
        }

        //submits the appointment from the signups page
        [HttpPost]
        public IActionResult Signups(Tour tour)
        {
            
            if (ModelState.IsValid)
            {
                //calls the Form view, and passes the selected tour to it
                return View("Form", tour);
            }
            return View();
        }

        //returns the page where the user submits their information and signs up for a specific tour
        [HttpGet]
        public IActionResult Form(Tour tour)
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View();
            };
            return View();
        }

        //submits the person/group's imformation to book the tour. This updates the database
        [HttpPost]
        public IActionResult FormPost(Tour tour)
        {
            
            tour.Avail = false;

            //updates database to include the new information entered in by the user (appointment information)
            context.Tours.Update(tour);

            context.SaveChanges();
            return View("Index");
        }


        //returns a view that shows all of the appointments that have been made
        public IActionResult ViewAppointments(Tour tour)
        {
            if (ModelState.IsValid)
            {

                //returns all appointments (tours) that are no longer available (have already been booked)
                return View(new TourListViewModel
                {
                    Tours = _repository.Tours
                    .Where(t => t.Avail == false)
                    .OrderBy(t => t.DayTime)
                });
            }
            return View("Index");
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

﻿using Group1_7_Project1_IS413.Models;
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
        public HomeController(ILogger<HomeController> logger, ITourRepository repository, TourDbContext con)
        {
            _logger = logger;
            _repository = repository;
            context = con;
            
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
                    .OrderBy(t => t.DayTime)
                });
            }
            return View();
        }

        [HttpPost]
        public IActionResult Signups(Tour tour)
        {
            
            if (ModelState.IsValid)
            {
                
                return View("Form", tour);
            }
            return View();
        }

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

        [HttpPost]
        public IActionResult FormPost(Tour tour)
        {
            
            tour.Avail = false;
            context.Tours.Update(tour);

            context.SaveChanges();
            return View("Index");
        }

        public IActionResult ViewAppointments(Tour tour)
        {
            if (ModelState.IsValid)
            {
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

﻿using Group1_7_Project1_IS413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Controllers
{
    public class HomeController : Controller
    {   private ITourRepository _repository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITourRepository repository)
        {
            _logger = logger;
            _repository = repository; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signups()
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View(new Tour
                {
                    Tours = _repository.Tours
                    .Where(s => available == false)
                    .OrderbBy(s => Time)
                });
            };
            return View();
        }
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View(new TourViewModel
                {
                    Schedule = _repository.Tours
                    .Where(s => available == false)
                    .OrderbBy(s => Time)
                });
            };
            return View();
        }
        public IActionResult ViewAppointments ()
        {
            if (ModelState.IsValid)
            {
                //Bring in the schedule of availability
                return View(new ScheduleViewModel
                {
                    Schedule = _repository.Schedule
                    .Where(s => available == false)
                    .OrderbBy(s => Date && Time)
                })
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

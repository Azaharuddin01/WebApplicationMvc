﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;

        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            List<Customer> Customers = dbContext.Customers.Where(e => e.Location.Id == id).ToList();
            return View(Customers);

        }

    }
}

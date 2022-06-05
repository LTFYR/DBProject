﻿using DBProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DBProject.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

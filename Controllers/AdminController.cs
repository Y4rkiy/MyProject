using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;

namespace MyProject.Controllers
{
    public class AdminController : Controller
    {
        readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();

            return View(users);
        }
    }
}

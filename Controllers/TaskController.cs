using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;

namespace MyProject.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext db;
        public TaskController(ApplicationDbContext db)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

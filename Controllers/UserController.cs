using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;

namespace MyProject.Controllers
{
    public class UserController : Controller
    {
        readonly ApplicationDbContext db;
        public UserController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.IdentityUsers.ToList());
        }
    }
}

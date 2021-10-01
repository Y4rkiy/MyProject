using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<MathTask> MathTasks { get; set; }
    }
}

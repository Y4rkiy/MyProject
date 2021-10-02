using Microsoft.AspNetCore.Identity;
using MyProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class MathTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Them { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        //public MathTask()
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Text = Text;
        //    this.Them = Them;
        //    this.UserId = ApplicationUser.Id;
        //}

    }
}

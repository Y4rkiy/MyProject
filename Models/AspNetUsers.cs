using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class AspNetUsers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Tasks { get; set; }
        //public int SolvedTasksCount { get; set; }
        //public int CreatedTasksCount { get; set; }
        public string Email { get; set; }
    }
}

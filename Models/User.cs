using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Tasks { get; set; }
        public int SolvedTasksCount { get; set; }
        public int CreatedTasksCount { get; set; }
    }
}

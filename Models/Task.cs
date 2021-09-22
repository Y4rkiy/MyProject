using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Text { get; set; }
        public int Topic { get; set; }
        public int Tags { get; set; }
        public int Pictures { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string TaskId { get; set; }
        public MathTask MathTask { get; set; }
    }
}

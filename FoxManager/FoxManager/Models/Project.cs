using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Project
    {
        public int TaskId { get; set; }
        public string DescriptionOfTask { get; set; }
        public int DueDate { get; set; }
        public int PriorityLevel { get; set; }

        public Student Student { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
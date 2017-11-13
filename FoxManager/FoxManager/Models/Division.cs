using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Division
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Technology { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
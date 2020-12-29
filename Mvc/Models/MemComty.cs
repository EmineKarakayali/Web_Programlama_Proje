using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class MemComty
    {
        public int Id { get; set; }

        public Community Community { get; set; }
        public Member Member { get; set; }
    }
}

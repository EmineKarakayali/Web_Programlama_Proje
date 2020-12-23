using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class MemComty
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemberId { get; set; }

        public Community Community { get; set; }
        public Member Member { get; set; }
    }
}

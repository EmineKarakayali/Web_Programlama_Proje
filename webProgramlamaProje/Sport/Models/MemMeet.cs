using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class MemMeet
    {
        public int Id { get; set; }
        public int MeetId { get; set; }
        public int MemberId { get; set; }

        public Meeting Meeting { get; set; }
        public Member Member { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class MemSport
    {
        public int Id { get; set; }
        public int MemberID { get; set; }
        public int SportId { get; set; }

        public Sports Sports { get; set; }
        public Member Member { get; set; }

    }
}

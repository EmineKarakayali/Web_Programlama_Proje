using Sport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class Meeting
    {
        [Key]
        public int MeetId { get; set; }
        public string ActName { get; set; }
        public string Location { get; set; }
        public int? Capasity { get; set; }
        public DateTime ActTime { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public Sports Sports { get; set; }
    }
}

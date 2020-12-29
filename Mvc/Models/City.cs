using SportProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportProject.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
    }
}

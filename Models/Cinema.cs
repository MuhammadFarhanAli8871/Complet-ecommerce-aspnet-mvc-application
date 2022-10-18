using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Cinema
    {
        [Key]
        // This id for table of actor in database
        public int ID { get; set; }
        public string CinemaLogo { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Producer
    {
        [Key]
        // This id for table of actor in database
        public int ID { get; set; }
        public string ProfilePictrueURL { get; set; }
        public string FullName { get; set; }
        public string BioData { get; set; }
    }
}

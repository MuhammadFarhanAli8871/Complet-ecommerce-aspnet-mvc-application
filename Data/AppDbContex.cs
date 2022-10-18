using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Data
{
    public class AppDbContex : DbContext
    {
        // Define Constructor
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options); 
        {
          
        }
    }
}

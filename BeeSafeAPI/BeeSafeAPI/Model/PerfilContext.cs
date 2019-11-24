using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeSafeAPI.Model
{
    public class BeeSafeContext : DbContext
    {
        public BeeSafeContext(DbContextOptions<BeeSafeContext> options)
            : base(options)
        {
        }


    }
}

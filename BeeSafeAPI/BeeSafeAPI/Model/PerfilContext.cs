﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeSafeAPI.Model
{
    public class BeeSafeContext : DbContext
    {
        public BeeSafeContext(DbContextOptions<BeeSafeContext> options) : base(options)
        {

        }

        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Trajeto> Trajeto { get; set; }
        }
}

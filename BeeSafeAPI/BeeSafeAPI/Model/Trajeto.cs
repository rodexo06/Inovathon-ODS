using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeSafeAPI.Model
{
    public class Trajeto
    {
        public int IdTrajeto { get; set; }
        public string LocalIni { get; set; }
        public string LocalFin { get; set; }
        public int User { get; set; }

    }
}

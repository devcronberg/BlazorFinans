using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace BlazorFinans.Kerne
{
    public class BeregnYdelse
    {
        [Range(1, 100000000, ErrorMessage = "Forkert hovedstol")]
        public double? Hovedstol { get; set; }

        [Range(1, 100, ErrorMessage = "Forkert rente")]
        public double? Rente { get; set; }
        
        [Range(1, 1000, ErrorMessage = "Forkert antal terminer")]
        public int? AntalTerminer { get; set; }

        public double BeregnetYdelse { get; set; }
    }
}

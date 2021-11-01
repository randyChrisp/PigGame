using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PigGame.Models
{
    public class Roll
    {
        public int Total { get; set; }

        public int Die { get; set; }

        public bool Continue { get; set; }
    }
}

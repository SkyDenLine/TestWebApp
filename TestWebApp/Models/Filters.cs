using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Models
{
    public class Filters
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Sum { get => X1 + X2; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Fundamentals
{
    public class Cookies
    {
        // "prop" + tab x2 gives you the line below:
        //Properties are Pascal case, not camel case
        public string Name { get; set; }
        public bool GlutenFree { get; set; }
        public int BatchSize { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_wpf.Interfaces;

namespace Question02_wpf.Models
{
    class Geo : IGeo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}

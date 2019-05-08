using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_wpf.Models;

namespace Question02_wpf.Interfaces
{
        interface ISupervisor
        {
            string Name { get; set; }
            string Phone { get; set; }
            string Email { get; set; }
            Address Address { get; set; }
            string Display_Data(List<Supervisor> Data);
        }
}

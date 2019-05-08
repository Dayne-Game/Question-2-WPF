using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_wpf.Models;

namespace Question02_wpf.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string Display_Data(List<Person> Data);
    }
}

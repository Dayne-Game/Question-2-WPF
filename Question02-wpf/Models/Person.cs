using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_wpf.Interfaces;

namespace Question02_wpf.Models
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Display_Data(List<Person> Data)
        {
            string output = "";
            foreach (Person i in Data)
            {
                output += $"Name: {i.Name} \nPhone Number: {i.Phone} \nEmail: {i.Email} \n\n";
            }
            return output;
        }
    }
}

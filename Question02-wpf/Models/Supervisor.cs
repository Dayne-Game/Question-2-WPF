using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02_wpf.Interfaces;

namespace Question02_wpf.Models
{
    public class Supervisor : ISupervisor
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public string Display_Data(List<Supervisor> Data)
        {
            string output = "";
            foreach (Supervisor i in Data)
            {
                output += $"Name: {i.Name} \nPhone Number: {i.Phone} \nEmail: {i.Email} \nStreet: {i.Address.Street} \nCity: {i.Address.City}\n\n";
            }
            return output;
        }
    }
}
